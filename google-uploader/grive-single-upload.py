#!/usr/bin/python

import httplib2
import json
import sys
from apiclient.discovery import build
from apiclient.http import MediaFileUpload
from oauth2client.client import OAuth2WebServerFlow
from oauth2client.file import Storage
from os.path import basename
import mimetypes

def getMIME(filename):
	mimetypes.init()
	return mimetypes.guess_type(filename)[0]
	
#read json data
json_data = open('params.json','r')
token_data = json.load(json_data)
json_data.close()


# Copy your credentials from the APIs Console
CLIENT_ID = token_data["clientID"]
CLIENT_SECRET = token_data["clientSecret"]
FILE_ID = token_data["fileID"]

if CLIENT_ID == "" or CLIENT_SECRET == "":
	print "Get your own api key from google"
	sys.exit(1)

# Check https://developers.google.com/drive/scopes for all available scopes
OAUTH_SCOPE = 'https://www.googleapis.com/auth/drive'

# Redirect URI for installed apps
REDIRECT_URI = 'urn:ietf:wg:oauth:2.0:oob'

# Path to the file to upload
FILEPATH = sys.argv[1]

storage = Storage('.credentials')
credentials = storage.get()
if credentials == None:
	# Run through the OAuth flow and retrieve credentials
	flow = OAuth2WebServerFlow(CLIENT_ID, CLIENT_SECRET, OAUTH_SCOPE, REDIRECT_URI)
	authorize_url = flow.step1_get_authorize_url()
	print 'Go to the following link in your browser: ' + authorize_url
	code = raw_input('Enter verification code: ').strip()
	credentials = flow.step2_exchange(code)
	storage = Storage('.credentials')
	storage.put(credentials)


# Create an httplib2.Http object and authorize it with our credentials
http = httplib2.Http()
http = credentials.authorize(http)

drive_service = build('drive', 'v2', http=http)

filename = basename(FILEPATH)
mimetype = getMIME(filename)

if FILE_ID == "":
	# Insert a file
	media_body = MediaFileUpload(FILEPATH, mimetype=mimetype, resumable=True)
	body = {
			'title': filename,
			'description': 'backup from server',
			'mimeType': getMIME(filename)
			}

	file = drive_service.files().insert(body=body, media_body=media_body).execute()

	#insert new file and save file's id
	FILE_ID = file["id"]
	token_data["fileID"] = FILE_ID
	json_data = open('params.json','w+')
	json_data.write(json.dumps(token_data))
	json_data.close()
	
else:
	#TODO need to handle when file deleted remote 
	file = drive_service.files().get(fileId=FILE_ID).execute()
	if (file['labels']['trashed']):
		# Insert a file
		media_body = MediaFileUpload(FILEPATH, mimetype=mimetype, resumable=True)
		body = {
				'title': filename,
				'description': 'backup from server',
				'mimeType': getMIME(filename)
				}
	
		file = drive_service.files().insert(body=body, media_body=media_body).execute()

		#insert new file and save file's id
		FILE_ID = file["id"]
		token_data["fileID"] = FILE_ID
		json_data = open('params.json','w+')
		json_data.write(json.dumps(token_data))
		json_data.close()

	else:
		media_body = MediaFileUpload(FILEPATH, mimetype='text/plain', resumable=True)
		updated_file = drive_service.files().update(fileId=FILE_ID, body=file, media_body=media_body).execute()
