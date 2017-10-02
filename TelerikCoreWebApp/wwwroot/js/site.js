
var onClickButton1 = function (e) {
    var data = e.data;
    var $popupWindow = $("#popupWindow" + data);
    var popupWindow = $popupWindow.data("kendoWindow");
    popupWindow.open();
};

$(document).ready(function () {
    $("#button1").bind("click", 1, onClickButton1);
});

