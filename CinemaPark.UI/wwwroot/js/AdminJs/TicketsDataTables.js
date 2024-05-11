$(document).ready(function () {
    $("#ticketTable").dataTable({
       
        ajax: {
            url: "/Admin/Admin/GetTickets",
            dataSrc:""         
        },
        columns: [
            { data: "id" },
            { data: "seatNumber" },
            { data: "price" },
            { data: "purchaseDate" }
        ]

    });
});