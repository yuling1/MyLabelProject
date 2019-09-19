window.onload=function(){
    var totalHeight = document.documentElement.clientHeight;
    var toolBarHeight = document.getElementById("toolBar").offsetHeight;
    var contentElement = document.getElementById("content");
    contentElement.style.height = totalHeight-toolBarHeight+"px";
}