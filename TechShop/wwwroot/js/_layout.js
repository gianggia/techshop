
$('#btn-search-product').on('click', function (e) {
    debugger
    e.preventDefault()
    var keyWord = $('#txt-search-product').val();
    location.href = '/product/index?keyWord=' + keyWord

})
