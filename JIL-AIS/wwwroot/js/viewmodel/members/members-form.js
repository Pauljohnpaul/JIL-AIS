$(document).ready(function () {
    memberformmodel.initialize();
});

var memberformmodel = {
    initialize: function () {
        $("#menu-management").addClass('kt-menu__item--active');
        $("#txtLstNme").focus();

        this.bindEvents();
    },
    bindEvents: function () {

    }
}