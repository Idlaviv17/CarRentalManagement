function AddDataTable(table) {
    $(document).ready(function () {
        $(table).DataTable();
    })
}

function DataTablesDispose(table) {
    $(document).ready(function () {
        $(table).DataTable().destroy();
        let element = document.querySelector(table + '_wrapper');
        element.parentNode.removeChild(element);
    })
}