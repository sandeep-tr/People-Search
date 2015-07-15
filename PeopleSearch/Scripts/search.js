$(function () {

    // -- Helper method to get interest array as a string
    var buildInterests = function (interests){
        var string = '';
        if (interests.length <= 0) {
            string = ', -';
        }
        else {
            interests.forEach(function (interest) {
                string += ', ' + interest.Interest;
            })
        }
        return string.substring(2);
    }

    // -- Helper method to get address object as a string
    var buildAddress = function (address) {
        var string = '';
        string += (address.Street == null) ? '' : address.Street;
        string += (address.City == null) ? '' : ', ' + address.City;
        string += (address.State == null) ? '' : ', ' + address.State;
        if (string == '') {;
            string = '-'
        }
        return string;
    }

    // -- Sends search query to the Server and receives JSON as response.
    // -- The response received is used to build HTML content, to be displayed as results.
    var search = function (initial){
        var query = null;
        if(!initial){
            query = $("#query").val();
        }
        var options = {
            url: "People/Search",
            data:{"query": query},
            type: "GET"
        };
        $.ajax(options).done(function (data) {
            var content = '<table class="table"><tr><th>Name</th><th>Age</th><th>Address</th><th>Interests</th></tr>';
            data.forEach(function (item) {
                content += '<tr><td><img src="Content/images/' + item.Image + '" class="img-thumbnail profileThumbnail">';
                content += item.Name + '</td>';
                content += '<td>' + item.Age + '</td><td>' + buildAddress(item.Address) + '</td>';
                content += '<td>' + buildInterests(item.Interests) + '</td></tr>';
            });
            content += '</table>';
            $("#peopleList").html(content);
        })
    }

    $(document).ready(function () { search(true) });
    $("#searchBtn").click(function () { search(false) });
});


