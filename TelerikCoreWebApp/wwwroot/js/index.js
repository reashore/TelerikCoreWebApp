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
    var freeIndex = undefined;

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
    //open: onOpen,
    //activate: onActivate,
    //refresh: onRefresh,
    //resize: onResize,
    //dragstart: onDragStart,
    //dragend: onDragEnd,
    //deactivate: onDeactivate,
    //minimize: onMinimize,
    //maximize: onMaximize,
    //close: onClosePopupWindow
};

//-----------------------------------------------------

var popupWindow10Configuration = {
    title: "Popup Window10",
    content: "/Work1/Index0"
};

var popupWindow11Configuration = {
    title: "Popup Window11",
    content: "/Work1/Index1"
};

var popupWindow12Configuration = {
    title: "Popup Window12",
    content: "/Work1/Index2"
};

var popupWindow13Configuration = {
    title: "Popup Window13",
    content: "/Work1/Index3"
};

var popupWindow14Configuration = {
    title: "Popup Window14",
    content: "/Work1/Index4"
};

var popupWindow15Configuration = {
    title: "Popup Window15",
    content: "/Work1/Index5"
};

var popupWindow16Configuration = {
    title: "Popup Window16",
    content: "/Work1/Index6"
};

//-----------------------------------------------------

var popupWindow20Configuration = {
    title: "Popup Window20",
    content: "/Work2/Index0"
};

var popupWindow21Configuration = {
    title: "Popup Window21",
    content: "/Work2/Index1"
};

var popupWindow22Configuration = {
    title: "Popup Window22",
    content: "/Work2/Index2"
};

var popupWindow23Configuration = {
    title: "Popup Window23",
    content: "/Work2/Index3"
};

var popupWindow24Configuration = {
    title: "Popup Window24",
    content: "/Work2/Index4"
};

var popupWindow25Configuration = {
    title: "Popup Window25",
    content: "/Work2/Index5"
};

var popupWindow26Configuration = {
    title: "Popup Window26",
    content: "/Work2/Index6"
};

//-----------------------------------------------------

var getPopupWindowConfiguration = function (menuItemText) {
    var popupWindowConfiguration = null;

    switch(menuItemText) {
        case "Menu1 Item0":
            popupWindowConfiguration = popupWindow10Configuration;
            break;

        case "Menu1 Item1":
            popupWindowConfiguration = popupWindow11Configuration;
            break;

        case "Menu1 Item2":
            popupWindowConfiguration = popupWindow12Configuration;
            break;

        case "Menu1 Item3":
            popupWindowConfiguration = popupWindow13Configuration;
            break;

        case "Menu1 Item4":
            popupWindowConfiguration = popupWindow14Configuration;
            break;

        case "Menu1 Item5":
            popupWindowConfiguration = popupWindow15Configuration;
            break;

        case "Menu1 Item6":
            popupWindowConfiguration = popupWindow16Configuration;
            break;

        //--------

        case "Menu2 Item0":
            popupWindowConfiguration = popupWindow20Configuration;
            break;

        case "Menu2 Item1":
            popupWindowConfiguration = popupWindow21Configuration;
            break;

        case "Menu2 Item2":
            popupWindowConfiguration = popupWindow22Configuration;
            break;

        case "Menu2 Item3":
            popupWindowConfiguration = popupWindow23Configuration;
            break;

        case "Menu2 Item4":
            popupWindowConfiguration = popupWindow24Configuration;
            break;

        case "Menu2 Item5":
            popupWindowConfiguration = popupWindow25Configuration;
            break;

        case "Menu2 Item6":
            popupWindowConfiguration = popupWindow26Configuration;
            break;
    }

    $.extend(popupWindowConfiguration, defaultPopupWindowConfiguration);

    return popupWindowConfiguration;
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
        var $statusBarButton = $("#statusBarButton" + n);
        $statusBarButton.on("click", null, n, onClickStatusBarButton);
    }
};

//-------------------------------------------------------------
// Event Handlers

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

//-------------------------------------------------------------

var popupWindowArray = [];

$(document).ready(function () {
    var numberItems = 12;

    attachEventHandlers();
    popupWindowArray = createPopupWindowArray(numberItems);

    console.log(popupWindowArray);
});

//-------------------------------------------------------------                                                                                               

//var onOpen = function (e) {
//    console.log("onOpen");
//};

//var onActivate = function (e) {
//    console.log("onActivate");
//};

//var onRefresh = function (e) {
//    console.log("onRefresh");
//};

//var onResize = function (e) {
//    console.log("onResize");
//};

//var onDragStart = function (e) {
//    console.log("onDragStart");
//};

//var onDragEnd = function (e) {
//    console.log("onDragEnd");
//};

//var onDeactivate = function (e) {
//    console.log("onDeactivate");
//};

//var onMinimize = function (e) {
//    console.log("onMinimize");
//};

//var onMaximize = function (e) {
//    console.log("onMaximize");
//};
