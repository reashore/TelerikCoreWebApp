"use strict";


var popupWindowArray = [];
var popupWindowInUseArray = [];

var createPopupWindowArray = function(numberItems) {
    var popupWindowArray = [];

    for (var n = 0; n < numberItems; n++) {
        popupWindowArray.push($("#popupWindow" + n));
        popupWindowInUseArray.push(true);
    }

    return popupWindowArray;
};

var getIndexOfUnusedPopup = function (numberItems) {
    var freeIndex;

    // display warning if there is no free index

    for (var n = 0; n < numberItems; n++) {
        if (popupWindowInUseArray[n] === true) {
            freeIndex = n;
            break;
        }
    }

    return freeIndex;
};

//-----------------------------------------------------

var defaultPopupWindowConfiguration = {
    inUse: false,
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

var popupWindow0Configuration = {
    title: "Popup Window0",
    content: "/Work1/Index0"
};

var popupWindow1Configuration = {
    title: "Popup Window1",
    content: "/Work1/Index1"
};

var popupWindow2Configuration = {
    title: "Popup Window2",
    content: "/Work1/Index2"
};

var popupWindow3Configuration = {
    title: "Popup Window3",
    content: "/Work1/Index3"
};

var popupWindow4Configuration = {
    title: "Popup Window4",
    content: "/Work1/Index4"
};

var popupWindow5Configuration = {
    title: "Popup Window5",
    content: "/Work1/Index5"
};

// may be out of range
var popupWindow6Configuration = {
    title: "Popup Window6",
    content: "/Work1/Index6"
};

//-----------------------------------------------------

var getPopupWindowConfiguration = function (menuItemText) {
    var popupWindowconfiguration = null;

    switch(menuItemText) {
        case "Menu1 Item0":
            popupWindowconfiguration = popupWindow0Configuration;
            break;

        case "Menu1 Item1":
            popupWindowconfiguration = popupWindow1Configuration;
            break;

        case "Menu1 Item2":
            popupWindowconfiguration = popupWindow2Configuration;
            break;

        case "Menu1 Item3":
            popupWindowconfiguration = popupWindow3Configuration;
            break;

        case "Menu1 Item4":
            popupWindowconfiguration = popupWindow3Configuration;
            break;

        case "Menu1 Item5":
            popupWindowconfiguration = popupWindow3Configuration;
            break;

        case "Menu1 Item6":
            popupWindowconfiguration = popupWindow3Configuration;
            break;






        case "Menu2 Item0":
            popupWindowconfiguration = popupWindow4Configuration;
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
    }

    $.extend(popupWindow1Configuration, defaultPopupWindowConfiguration);

    return popupWindowconfiguration;
};

//-------------------------------------------------------------
// Functions

var extractNumericSuffix = function (value, prefix) {
    var prefixLength = prefix.length;
    var index = prefixLength - 1;
    return value.slice(index);
};

var attachEventHandlers = function () {
    var numberItems = 6;

    for (var n = 0; n < numberItems; n++) {
        //var menuItem = $("#menuItem" + n);
        //menuItem.bind("click", n, onClickMenuItem);

        var $statusBarButton = $("#statusBarButton" + n);
        $statusBarButton.on("click", null, n, onClickStatusBarButton);
    }
};


//-------------------------------------------------------------
// Event Handlers

//var onClickMenuItem = function (e) {
//    var data = e.data;

//    var menuItem = $("#menuItem" + data);
//    menuItem.prop("disabled", true);

//    var $popupWindow = $("#popupWindow" + data);
//    $popupWindow.empty();
//    var windowConfiguration = {
//        title: "Popup Window New",
//        resizable: true,
//        width: 600,
//        height: 400,
//        maxHeight: 500,
//        maxWidth: 500,
//        content: { url: "/Home/Index2" }
//    };
//    var popupWindow = $popupWindow.kendoWindow(windowConfiguration);
//    popupWindow = popupWindow.data("kendoWindow");
//    $("#popupWindow1_wnd_title").text("New Popup Window1");
//    popupWindow.open();
//};

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
    var numberItems = 6;
    var $item = $(e.item);
    var menuItemText = $item.children(".k-link").text();
    console.log("Selected: " + menuItemText);
    var popupWindowConfiguration = getPopupWindowConfiguration(menuItemText);

    // replace with code to get next free window
    var freePopupIndex = getIndexOfUnusedPopup(numberItems);
    console.log("FreePopupIndex = " + freePopupIndex);

    var $popupWindow = $("#popupWindow" + freePopupIndex);

    $popupWindow.empty();
    var popupWindow = $popupWindow.kendoWindow(popupWindowConfiguration);
    popupWindow = popupWindow.data("kendoWindow");
    $("#popupWindow" + freePopupIndex + "_wnd_title").text(popupWindowConfiguration.title);
    popupWindow.open();

    popupWindowInUseArray[freePopupIndex] = false;
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

