function ans=cosSimilarity(mat)
	temp_data=[];
	for i=1:size(mat,2)
		temp = mat(i,:);
		temp = temp/sqrt(dot(temp,temp));
		temp_data = [temp_data ; temp];
	end
	for i=1:size(mat,2)
		for j=1:size(mat,2)
			ans(i,j) = sum(temp_data(i,:).*temp_data(j,:));
		end
	end
endfunction

