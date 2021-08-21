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

  $(".ldmr").slice(0, 6).show();
  $(".btnldmr").on("click", function () {
    $(".ldmr:hidden").slice(0, 3).slideDown();
    if ($(".ldmr:hidden").length == 0) {
      $(".btnldmr").fadeOut("slow");
    }
  });

  $(".rating__input").click(function () {
    var star = $(this);
    console.log(star.val());
  });

  // Swal.fire({
  //   position: "top-end",
  //   icon: "success",
  //   title: "Məhsul səbətə əlavə olundu!",
  //   showConfirmButton: false,
  //   timer: 800,
  // });
});
