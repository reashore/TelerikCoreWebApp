
// Functions

var extractNumericSuffix = function (value, prefix) {
    var prefixLength = prefix.length;
    var index = prefixLength - 1;
    return value.slice(index);
};

var attachEventHandlers = function () {
    var numberItems = 6;

    for (var n = 1; n <= numberItems; n++) {
        var menuItem = $("#menuItem" + n);
        menuItem.bind("click", n, onClickMenuItem);

        var $statusBarButton = $("#statusBarButton" + n);
        $statusBarButton.on("click", null, n, onClickStatusBarButton);
    }
};

//-------------------------------------------------------------
// Event Handlers

var onClickMenuItem = function (e) {
    var data = e.data;

    var menuItem = $("#menuItem" + data);
    menuItem.prop("disabled", true);

    var $popupWindow = $("#popupWindow" + data);
    var popupWindow = $popupWindow.data("kendoWindow");
    popupWindow.open();
};

var onClickStatusBarButton = function (e) {
    var data = e.data;
    var $popupWindow = $("#popupWindow" + data);
    var popupWindow = $popupWindow.data("kendoWindow");
    popupWindow.open();
};

var onClosePopupWindow = function (e) {
    var id = e.sender.wrapper.context.id;
    var prefix = "#popupWindow";
    var index = extractNumericSuffix(id, prefix);
    var $menuItem = $("#menuItem" + index);
    $menuItem.prop("disabled", false);
};

var selectMenuItem = function (e) {
    var menuData = $(e.item).children(".k-link").text();
    console.log("Selected: " + menuData);
};

var onClickTest = function(e) {
    var data = e.data;
    var message = "onClickTest" + data + " clicked";
    console.log(message);

}

//-------------------------------------------------------------

$(document).ready(function () {
    attachEventHandlers();

    $("#statusBarButton1").on("click", null, 1, onClickTest);
    $("#statusBarButton2").on("click", null, 2, onClickTest);
    $("#statusBarButton3").on("click", null, 3, onClickTest);
    $("#statusBarButton4").on("click", null, 4, onClickTest);
    $("#statusBarButton5").on("click", null, 5, onClickTest);
    $("#statusBarButton6").on("click", null, 6, onClickTest);
});





//var onClickMenuItem = function (e) {
//    var data = e.data;
//    var menuItem = $("#menuItem" + data);
//    var popupWindow = $("#popupWindow" + data);

//    //popupWindow.kendoWindow(
//    //    {
//    //        "title": "Popup Window New",
//    //        "resizable": true,
//    //        "width": 600,
//    //        "height": 400,
//    //        "maxHeight": 500,
//    //        "maxWidth": 500,
//    //        "content": { "url": "/Home/Index2" }
//    //    }
//    //);

//    //popupWindow.set_title("My Title");

//    popupWindow.data("kendoWindow").open();
//    menuItem.prop("disabled", true);
//};
