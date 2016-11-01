var dealershipViewModel;

function Dealership() {
    var self = this;


}

function DealershipViewModel(id, companyName, email, city, state, zipCode, notes, phoneNumber, faxNumber) {
    var self = this;

    //observables
    self.Id = ko.observable(id);
    self.CompanyName = ko.observable(companyName);
    self.Email = ko.observable(email);
    self.City = ko.observable(city);
    self.State = ko.observable(state);
    self.ZipCode = ko.observable(zipCode);
    self.PhoneNumber = ko.observable(phoneNumber);
    self.FaxNumber = ko.observable(faxNumber);

    self.DealershipData = new Dealership();

    self.GetDealershipInfo = function () {
        $.ajax({
            type: "GET",
            url: "/Dealerships/GetCurrentDealershipInfo/",
            contentType: 'application/json',
            success: function (data) {
                self.DealershipData = new Dealership(data.Id, data.CompanyName, data.Email, data.City, data.State, data.ZipCode, data.Notes, data.PhoneNumber, data.faxNumber);
            },

        });
    }

    self.EditDealershipInfo = function () {
        $.ajax({
            type: "POST",
            url: "/Dealerships/Edit/" + self.Id(),
            contentType: "application/json",
            success: function (data) {

            }

        });
    }

}
dealershipViewModel = new DealershipViewModel();



// on document ready
$(document).ready(function () {

    // bind view model to referring view
    ko.applyBindings(dealershipViewModel);

    // load student data
    dealershipViewModel.GetDealershipInfo();
});