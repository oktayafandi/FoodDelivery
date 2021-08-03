$(document).ready(function () {


    $(document).on("click", ".delete-btn", function (e) {

        console.log("testing")
        e.preventDefault();

        var url = $(this).attr("href")

        Swal.fire({
            title: 'Silmək istədiyinə əminsən?',
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Sil'
        }).then((result) => {
            if (result.isConfirmed) {

                fetch(url)
                    .then(response => response.json())
                    .then(data => {
                        if (data.isSuccedded) {
                            Swal.fire(
                                'Deleted!',
                                'Your file has been deleted.',
                                'success'
                            )

                            $(this).removeClass("btn-danger")
                            $(this).addClass("btn-info")
                            $(this).text("Restore")
                            var restoreUrl = $(this).data("restore-url");
                            $(this).attr("href", restoreUrl)
                            $(this).removeClass("delete-btn")
                        }
                    });
            }
            else {
                console.log("Heç bir əməliyyat baş vermədi")
            }
        })
    })
})