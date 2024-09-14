var handleDataTableSelect = function () {
	"use strict";

	//if ($('#data-table-select').length !== 0) {

	//	$('#data-table-select').DataTable({ select: true, responsive: true });

	//}

	if ($('#data-table-select').length !== 0) {
		var options = {
			dom: '<"dataTables_wrapper dt-bootstrap"<"row"<"col-xl-7 d-block d-sm-flex d-xl-block justify-content-center"<"d-block d-lg-inline-flex me-0 me-md-3"l><"d-block d-lg-inline-flex"B>><"col-xl-5 d-flex d-xl-block justify-content-center"fr>>t<"row"<"col-md-5"i><"col-md-7"p>>>',
			buttons: [
				{ extend: 'copy', className: 'btn-sm' },
				{ extend: 'csv', className: 'btn-sm' },
				{ extend: 'excel', className: 'btn-sm' },
				{ extend: 'pdf', className: 'btn-sm' },
				{ extend: 'print', className: 'btn-sm' }
			],
			responsive: true,
			colReorder: true,
			keys: true,
			rowReorder: true,
			select: true
		};

		if ($(window).width() <= 767) {
			options.rowReorder = true;
			options.colReorder = false;
		}
		$('#data-table-select').DataTable(options);
	}
};

var Setting_DataTableSelect = function () {
	"use strict";
	return {
		//main function
		init: function () {
			alert('Setting_DataTableSelect: Start');
			handleDataTableSelect();
			alert('Setting_DataTableSelect: Sucess');

		}
	};
}();