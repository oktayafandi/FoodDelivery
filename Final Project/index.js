$(document).ready(function () {
  var searchiconcount = 0;
  $(".searchbtn").click(function (e) {
    e.preventDefault();
    searchiconcount++;
    if (searchiconcount % 2 == 1) {
      $(".searchform").css({ display: "block" });
    } else {
      $(".searchform").css({ display: "none" });
    }
  });

  $(document).scroll(function () {
    if (window.scrollY >= 22) {
      $(".navbar").addClass("navbar-position-class");
    } else {
      $(".navbar").removeClass("navbar-position-class");
    }
  });
});
