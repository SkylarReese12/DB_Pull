$(document).ready(function () {
    var apiBaseUrl = "http://localhost:51315/";
    $('#btnGetData').click(function () {
        $.ajax({
            url: apiBaseUrl + 'api/Student',
            type: 'GET',
            dataType: 'json',
            success: function (data) {
                var $table = $('<table/>').addClass('dataTable table table-bordered table-striped');
                var $header = $('<thead/>').html('<tr><th>Student ID</th><th>School ID</th><th>Competition ID</th><th>First Name</th><th>Last Name</th><th>Coach</th><th>Type</th><th>T-shirt Size</th><th>Grade</th><th>Level ID</th><th>Computer Program ID</th><th>Final</th><th>Award</th><th>Create Date</th><th>Year</th><th>Coach Email</th><th>Comptetition</th><th>Competition Level</th><th>Computer Program</th><th>Liability Form</th><th><th>School</th></tr>');
                $table.append($header);
                $.each(data, function (i, val) {
                    var $row = $('<tr/>');
                    $row.append($('<td/>').html(val.STUDENT_ID));
                    $row.append($('<td/>').html(val.SCHOOL_ID));
                    $row.append($('<td/>').html(val.COMPETITION_ID));
                    $row.append($('<td/>').html(val.FIRST_NAME));
                    $row.append($('<td/>').html(val.LAST_NAME));
                    $row.append($('<td/>').html(val.COACH));
                    $row.append($('<td/>').html(val.TYPE));
                    $row.append($('<td/>').html(val.TSHIRT_SIZE));
                    $row.append($('<td/>').html(val.GRADE));
                    $row.append($('<td/>').html(val.LEVEL_ID));
                    $row.append($('<td/>').html(val.COMPUTERPROGRAM_ID));
                    $row.append($('<td/>').html(val.FINAL));
                    $row.append($('<td/>').html(val.AWARD));
                    $row.append($('<td/>').html(val.CREATE_DATE));
                    $row.append($('<td/>').html(val.YEAR));
                    $row.append($('<td/>').html(val.COACHEMAIL));
                    $table.append($row);
                });
                $('#updatePanel').html($table);
            },
            error: function () {
                alert('Error!');
            }
        });
    });
})