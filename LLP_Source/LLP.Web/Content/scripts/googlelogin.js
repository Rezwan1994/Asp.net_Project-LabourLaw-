﻿function HandleGoogleApiLibrary() {
    console.log( $('#gmailkey').val())
    // Load "client" & "auth2" libraries
    gapi.load('client:auth2', {
        callback: function () {
            // Initialize client library
            // clientId & scope is provided => automatically initializes auth2 library
            gapi.client.init({
              
            
                apiKey: $('#gmailkey').val(),
                clientId: '166658674521-r4v7uc28o85b2uv98tipv5kte86j8vc8.apps.googleusercontent.com',
                scope: 'https://www.googleapis.com/auth/userinfo.profile https://www.googleapis.com/auth/userinfo.email https://www.googleapis.com/auth/plus.me'
            }).then(
				// On success
				function (success) {
				    // After library is successfully loaded then enable the login button
				    //$("#login-button").removeAttr('disabled');
				},
				// On error
				function (error) {
				    alert('Error : Failed to Load Library');
				}
			);
        },
        onerror: function () {
            // Failed to load libraries
        }
    });
}
$(document).ready(function () {

    $("#googlelogin").on('click', function () {
        // API call for Google login
        gapi.auth2.getAuthInstance().signIn().then(
            // On success
            function (success) {
                // API call to get user information
                gapi.client.request({ path: 'https://www.googleapis.com/plus/v1/people/me' }).then(
                    // On success
                    function (success) {
                        console.log(success);
                        var user_info = JSON.parse(success.body);
                        UserRegistrationinfo(user_info);
                    },
                    // On error
                    function (error) {
                        $("#login-button").removeAttr('disabled');
                        alert('Error : Failed to get user user information');
                    }
                );
            },
            // On error
            function (error) {
                $("#login-button").removeAttr('disabled');
                alert('Error : Login Failed');
            }
        );
    });
});
var UserRegistrationinfo = function (googledata) {
    console.log(googledata);
    var UserName = googledata.displayName;
    var EmailAddress = googledata.emails[0].value;
    var GoogleId = googledata.id;
    var url = '/Home/GoogleLogin';
    var param = JSON.stringify({ 
        
        UserName: UserName,
        EmailAddress: EmailAddress,
        GoogleId: GoogleId
    });
    console.log(param);
    $.ajax({
        type: "POST",
        url: url,
        data: param,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        cache: false,
        success: function (data) {
            if (data.result) {
               window.location.href = data.url;
            }
            else {
                alert(data.url);
            }

        },

        error: function (jqXHR, textStatus, errorThrown) {
            console.log(errorThrown);
        }
    });
}