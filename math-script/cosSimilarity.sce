function[dat]=cosSimilarity(mat)
    temp_data=[];
    for i=1:size(mat,"r")
        temp = [mat(i,:) ];
        temp = temp/sqrt(sum(temp^2));
        temp_data = [temp_data;temp];
    end
    
    for i=1:size(mat,"r")
        for j=1:size(mat,"r")
            dat(i,j) = sum(temp_data(i,:).*temp_data(j,:));
        end
    end
endfunction