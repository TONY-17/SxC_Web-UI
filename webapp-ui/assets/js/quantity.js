function increase() {
    var value = document.getElementById('ContentPlaceHolder1_quantity_input').value;
    value = isNaN(value) ? 1 : value;
    value++;
    document.getElementById('ContentPlaceHolder1_quantity_input').value = value;
}

function decrease() {
    var value = document.getElementById('ContentPlaceHolder1_quantity_input').value;
    value = isNaN(value) ? 1 : value;
    value--;
    value < 1 ? value = 1 : '';
    document.getElementById('ContentPlaceHolder1_quantity_input').value = value;
}
