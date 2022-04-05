$(function () {
  $('.js-basic-example').DataTable({
    "scrollX": true,
    responsive: true,
    searching: false,
    lengthChange: false,
    "language": {
      "url": "//cdn.datatables.net/plug-ins/1.10.16/i18n/Portuguese-Brasil.json"
    }
  });

  //Exportable table
  $('.js-exportable').DataTable({
    dom: 'Bfrtip',
    responsive: true,
    buttons: [
        'copy', 'csv', 'excel', 'pdf', 'print'
    ]
  });
});