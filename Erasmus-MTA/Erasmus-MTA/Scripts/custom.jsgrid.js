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

var tip = [
	{ Name: "", Id: 0 },
	{ Name: "SMS", Id: 1 },
	{ Name: "SMP", Id: 2 },
	{ Name: "STA", Id: 3 },
	{ Name: "STT", Id: 4 },
	{ Name: "SOM", Id: 5 },


];
var nivel = [
	   { Name: "", Id: 0 },
		{ Name: "L", Id: 1 },
	   { Name: "M", Id: 2 },
	   { Name: "D", Id: 3 },
	   { Name: "P", Id: 4 },
	 { Name: "A", I5: 5 },
]

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
		{ name: "Nume si prenume", type: "number", width: 150, validate: "required" },
		{
			type: "control", width: 150,
			itemTemplate: function (value, item) {
				var $result = jsGrid.fields.control.prototype.itemTemplate.apply(this, arguments);

				var $customButton = $("<button>")
					.text("Detalii")
					.click(function (e) {
						alert("Age: " + item.Age);
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
						alert("Age: " + item.Age);
						e.stopPropagation();
					});

				return $result.add($customButton);
			}
		}
	]
});