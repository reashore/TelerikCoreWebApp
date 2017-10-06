"use strict";

//-----------------------------------------------------

//var numberItems = 6;

//var popupWindowIdArray = ["popupWindow1", "popupWindow2", "popupWindow3", "popupWindow4", "popupWindow5", "popupWindow6"];

//var popupWindows = popupWindowIdArray.forEach(function(item) {
//    $(item);
//});

var popupWindowArray = [];

var createPopupWindowArray = function (numberItems) {
    var popupWindowArray = [];

    for (var n = 1; n <= numberItems; n++) {
        popupWindowArray.push($("#popupWindow" + n));
    }

    return popupWindowArray;
}

//-----------------------------------------------------

var defaultPopupWindowConfiguration = {
    position: {
        top: 200,
        left: 600
    },
    width: 600,
    height: 300,
    maxHeight: 700,
    maxWidth: 700,
    draggable: true,
    iframe: true,
    modal: false,
    scrollable: true,
    visible: false,
    actions: ["Pin", "Refresh", "Minimize", "Maximize", "Close"],
    open: onOpen,
    activate: onActivate,
    refresh: onRefresh,
    resize: onResize,
    dragstart: onDragStart,
    dragend: onDragEnd,
    deactivate: onDeactivate,
    minimize: onMinimize,
    maximize: onMaximize,
    close: onClosePopupWindow
};

//-----------------------------------------------------

var popupWindow1Configuration = {
    title: "Popup Window1",
    content: "/Home/Index1"
};

var popupWindow2Configuration = {
    title: "Popup Window2",
    content: "/Home/Index2"
};

var popupWindow3Configuration = {
    title: "Popup Window3",
    content: "/Home/Index3"
};

var popupWindow4Configuration = {
    title: "Popup Window4",
    content: "/Home/Index4"
};

var popupWindow5Configuration = {
    title: "Popup Window5",
    content: "/Home/Index5"
};

var popupWindow6Configuration = {
    title: "Popup Window6",
    content: "/Home/Index6"
};

//-----------------------------------------------------

var getPopupWindowConfiguration = function (menuItemText) {
    var popupWindowconfiguration = null;

    switch(menuItemText) {
        case "Menu1 Item1":
            popupWindowconfiguration = popupWindow1Configuration;
            break;

        case "Menu1 Item2":
            popupWindowconfiguration = popupWindow2Configuration;
            break;

        case "Menu1 Item3":
            popupWindowconfiguration = popupWindow3Configuration;
            break;

        case "Menu2 Item1":
            popupWindowconfiguration = popupWindow4Configuration;
            break;

        case "Menu2 Item2":
            popupWindowconfiguration = popupWindow5Configuration;
            break;

        case "Menu2 Item3":
            popupWindowconfiguration = popupWindow6Configuration;
            break;

        //case "Menu3 Item1":
        //    popupWindowconfiguration = $.extend(popupWindow1Configuration, defaultPopupWindowConfiguration);
        //    break;

        //case "Menu3 Item2":
        //    popupWindowconfiguration = $.extend(popupWindow1Configuration, defaultPopupWindowConfiguration);
        //    break;

        //case "Menu3 Item3":
        //    popupWindowconfiguration = $.extend(popupWindow1Configuration, defaultPopupWindowConfiguration);
        //    break;
    }

    $.extend(popupWindow1Configuration, defaultPopupWindowConfiguration);

    return popupWindowconfiguration;
};

//var popupWindowsConfiguration = {
//    "Menu1 Item1": $.extend(popupWindow1Configuration, defaultPopupWindowConfiguration),
//    "Menu1 Item2": $.extend(popupWindow1Configuration, defaultPopupWindowConfiguration),
//    "Menu1 Item3": $.extend(popupWindow1Configuration, defaultPopupWindowConfiguration),

//    "Menu2 Item1": $.extend(popupWindow1Configuration, defaultPopupWindowConfiguration),
//    "Menu2 Item2": $.extend(popupWindow1Configuration, defaultPopupWindowConfiguration),
//    "Menu2 Item3": $.extend(popupWindow1Configuration, defaultPopupWindowConfiguration),

//    "Menu3 Item1": $.extend(popupWindow1Configuration, defaultPopupWindowConfiguration),
//    "Menu3 Item2": $.extend(popupWindow1Configuration, defaultPopupWindowConfiguration),
//    "Menu3 Item3": $.extend(popupWindow1Configuration, defaultPopupWindowConfiguration)
//};

//-------------------------------------------------------------
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
    $popupWindow.empty();
    var windowConfiguration = {
        title: "Popup Window New",
        resizable: true,
        width: 600,
        height: 400,
        maxHeight: 500,
        maxWidth: 500,
        content: { url: "/Home/Index2" }
    };
    var popupWindow = $popupWindow.kendoWindow(windowConfiguration);
    popupWindow = popupWindow.data("kendoWindow");
    $("#popupWindow1_wnd_title").text("New Popup Window1");
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
    var $item = $(e.item);
    //var parent = $item.parent("span.k-link").text();
    //console.log(parent);
    var menuItemText = $item.children(".k-link").text();
    console.log("Selected: " + menuItemText);

    var popupWindowConfiguration = getPopupWindowConfiguration(menuItemText);
    console.log(popupWindowConfiguration);
};

var onOpen = function(e) {
    //console.log("onOpen");
};

var onActivate = function(e) {
    //console.log("onActivate");
};

var onRefresh = function(e) {
    //console.log("onRefresh");
};

var onResize = function(e) {
    //console.log("onResize");
};

var onDragStart = function(e) {
    //console.log("onDragStart");
};

var onDragEnd = function(e) {
    //console.log("onDragEnd");
};

var onDeactivate = function(e) {
    //console.log("onDeactivate");
};

var onMinimize = function(e) {
    //console.log("onMinimize");
};

var onMaximize = function(e) {
    //console.log("onMaximize");
};

//-------------------------------------------------------------

var popupWindowArray = [];

$(document).ready(function () {
    var numberItems = 6;

    attachEventHandlers();
    popupWindowArray = createPopupWindowArray(numberItems);

    console.log(popupWindowArray);
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
