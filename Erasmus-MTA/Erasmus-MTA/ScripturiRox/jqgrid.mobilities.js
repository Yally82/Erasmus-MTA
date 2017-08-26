
//        Exemplu script JQGRID
$("#backFromModalMobilitate").click(function () {
 $('#myModalParticipant').show();
   $('#myModalMobilitate').hide();

});
//$(document).ready(function () {
//    $("#jsGrids").jqGrid({
//        width: "100%",
//        height: "750px",
//        filtering: true,
//        inserting: true,
//        selecting: true,
//        editing: true,
//        sorting: true,
//        paging: true,
//        pageSize: 15,
//        deleteConfirm: "Do you really want to delete the client?",

//        url: 'http://localhost/Home/getStudents',
//        datatype: "json",
//        contentType: "application/json; charset-utf-8",
//        mtype: 'GET',

//        colNames: ['ID', 'An', 'Tip mobilitate',
//            'Nivel', 'Nume si prenume'],
//        colModel: [
//            { name: 'ID', index: 'ID', width: 70, sorttype: "int" },
//            { name: 'An', index: 'An', width: 70 },
//            { name: 'Tip mobilitate', index: 'Tip mobilitate', width: 100 },
//            { name: 'Nivel', index: 'Nivel', width: 80 },
//            { name: 'Nume si prenume', index: 'City', width: 150 }
//        ],
//        rowNum: 5,
//        rowList: [5, 10, 15],
//        sortname: 'id',
//        viewrecords: true,
//        sortorder: "asc",
//        caption: "Studenti"
//    });
//});


        var clients = [
            { "ID": 0, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Nume si prenume": "Ionescu Alexandru Damian" },
            { "ID": 1, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Nume si prenume": "Ionescu Alexandru Damian" },
            { "ID": 2, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Nume si prenume": "Ionescu Alexandru Damian" },
            { "ID": 3, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Nume si prenume": "Ionescu Alexandru Damian" },
            { "ID": 4, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Nume si prenume": "Ionescu Alexandru Damian" },
            { "ID": 5, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Nume si prenume": "Ionescu Alexandru Damian" },
            { "ID": 6, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Nume si prenume": "Ionescu Alexandru Damian" },
            { "ID": 7, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Nume si prenume": "Ionescu Alexandru Damian" },
            { "ID": 8, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Nume si prenume": "Ionescu Alexandru Damian" },
            { "ID": 9, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Nume si prenume": "Ionescu Alexandru Damian" },
            { "ID": 10, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Nume si prenume": "Ionescu Alexandru Damian" },
            { "ID": 11, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Nume si prenume": "Ionescu Alexandru Damian" },
            { "ID": 12, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Nume si prenume": "Ionescu Alexandru Damian" },
            { "ID": 13, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Nume si prenume": "Ionescu Alexandru Damian" },
            { "ID": 14, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Nume si prenume": "Ionescu Alexandru Damian" },
            { "ID": 15, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Nume si prenume": "Ionescu Alexandru Damian" },
        ];
var mobilitati = [
  { "ID": 0, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Institutia gazda": "Univ Bilbao" },
  { "ID": 1, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Institutia gazda": "Univ Bilbao" },
  { "ID": 2, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Institutia gazda": "Univ Bilbao" },
  { "ID": 3, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Institutia gazda": "Univ Bilbao" },
  { "ID": 4, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Institutia gazda": "Univ Bilbao" },
  { "ID": 5, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Institutia gazda": "Univ Bilbao" },
  { "ID": 6, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Institutia gazda": "Univ Bilbao" },
  { "ID": 7, "An": 2005, "Tip mobilitate": 1, "Nivel": 3, "Institutia gazda": "Univ Bilbao" },

];
var tip = {
    name: "Tip mobilitate",
    type: "select",
    items: [
      { Name: "", Id: 0 },
      { Name: "SMS", Id: 1 },
      { Name: "SMP", Id: 2 },
      { Name: "SM", Id: 3 },
    ],
    valueField: "Id",
    textField: "Name"
}
var nivel = {
    name: "Nivel",
    type: "select",
    items: [
      { Name: "", Id: 0 },
      { Name: "L", Id: 1 },
      { Name: "M", Id: 2 },
      { Name: "P", Id: 3 },
    ],
    valueField: "Id",
    textField: "Name"
}

$("#jsGrids").jsGrid({
    width: "100%",
    height: "750px",

    filtering: true,
    inserting: true,
    selecting: true,
    editing: true,
    sorting: true,
    paging: true,
    pageSize: 15,


    deleteConfirm: "Do you really want to delete the client?",
    data: clients,

    fields: [
        { name: "ID", type: "number", width: 70, validate: "required" },
        { name: "An", type: "number", width: 70, validate: "required" },
        { name: "Tip mobilitate", type: "select", items: tip, valueField: "Id", textField: "Name" },
        { name: "Nivel", type: "select", items: nivel, valueField: "Id", textField: "Name" },
        { name: "Nume si prenume", type: "texts", width: 150, validate: "required" },
        {
            type: "control", width: 150,
            itemTemplate: function (value, item) {
                var $result = jsGrid.fields.control.prototype.itemTemplate.apply(this, arguments);

                var $customButton = $("<button>")
                    .text("Detalii")

                    .click(function (e) {
                        $('#myModalMobilitate').hide();
                        $('#myModal').modal('show');
                        $('#myModalParticipant').show();
                        e.stopPropagation();
                    });

                return $result.add($customButton);
            }
        }
    ]
});


$("#jsGridm").jsGrid({
    width: "100%",
    height: "400px",

    filtering: true,
    inserting: true,
    selecting: true,
    editing: true,
    sorting: true,
    paging: true,
    pageSize: 5,


    deleteConfirm: "Do you really want to delete the client?",
    data: mobilitati,

    fields: [
        { name: "ID", type: "number", width: 70, validate: "required" },
        { name: "An", type: "number", width: 70, validate: "required" },
        { name: "Tip mobilitate", type: "select", items: tip, valueField: "Id", textField: "Name" },
        { name: "Nivel", type: "select", items: nivel, valueField: "Id", textField: "Name" },
        { name: "Institutia gazda", type: "number", width: 150, validate: "required" },
        {
            type: "control", width: 150,
            itemTemplate: function (value, item) {
                var $result = jsGrid.fields.control.prototype.itemTemplate.apply(this, arguments);

                var $customButton = $("<button>")
                    .text("Detalii")

                    .click(function (e) {
                        $('#myModalMobilitate').show();
                        $('#myModalParticipant').hide();

                        e.stopPropagation();
                    });

                return $result.add($customButton);
            }
        }
    ]
});

$("#jsGridp").jsGrid({
    width: "100%",
    height: "750px",
    filtering: true,
    inserting: true,
    editing: true,
    sorting: true,
    paging: true,
    pageSize: 15,


    deleteConfirm: "Do you really want to delete the client?",
    data: clients,


    fields: [
        { name: "ID", type: "number", width: 70, validate: "required" },
        { name: "An", type: "number", width: 70, validate: "required" },
        { name: "Tip mobilitate", type: "select", items: tip, valueField: "Id", textField: "Name" },

        { name: "Nume si prenume", type: "number", width: 150, validate: "required" },
        {
            type: "control", width: 150,
            itemTemplate: function (value, item) {
                var $result = jsGrid.fields.control.prototype.itemTemplate.apply(this, arguments);

                var $customButton = $("<button>")
                    .text("Detalii")
                    .click(function (e) {
                        $('#myModal').modal('show');
                        $('#myModalMobilitate').hide();
                        $('#myModalParticipant').show();
                        e.stopPropagation();
                    });

                return $result.add($customButton);
            }
        }
    ]
});