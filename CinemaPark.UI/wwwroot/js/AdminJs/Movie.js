

$(document).ready(function () {
 
    $("#addBtn").click(function () {
       
        var movieData = {
            name: $("#MovieName").val(),
            director: $("#Director").val(),
            movieReleaseDate: $("#MovieReleaseDate").val(),
            description: $("#Description").val()
        };

        var movieName = movieList.Name;
        var director = movieList.Director;
        var movieReleaseDate = movieList.MovieReleaseDate;
        var description = movieList.Description;
      
        
        console.log(JSON.stringify({ movieList: movieData }));
        
        $.ajax({         
            async:true,
            url: "/Admin/Admin/AddMovie",
            type: "POST",
            dataType: "json",
            contentType: "application/json;  charset=utf-8",
            data: JSON.stringify({ movieList: movieData }),
            processData:false,
            
            success: function (response) {
                if (response.success) {
                    alert(response.message);

                } else {
                    alert('Failed to add movie');
                }
            },
            error: function (xhr, status, error) {
                console.error(error);
                alert('An error occurred while adding the movie');
            }


        });
    });
});

