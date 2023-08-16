<?php include'relations.php'?>

<body>
<?php include'navigation.php'?>
<nav style="--bs-breadcrumb-divider: '>';" aria-label="breadcrumb">
        <ol class="breadcrumb">
            <li class="breadcrumb-item"><a href="home.html">Home</a></li>
            <li class="breadcrumb-item active" aria-current="page">Contact Us</li>
        </ol>
    </nav>
    <div class="container-fluid">
        <div class="container">
            <div>
                <h2 class="text-center mb-5 shadow-sm p-3">Contact Us</h2>
            </div>
            <div class="row">
                <div class="col-md-7 shadow-sm p-3">
                    <div class="row">
                        <div class="col mb-3">
                            <label class="form-label">First Name</label>
                            <input type="text" class="form-control" placeholder="First Name">
                        </div>
                        <div class="col mb-3">
                            <label class="form-label">Last Name</label>
                            <input type="text" class="form-control" placeholder="Last Name">
                        </div>
                        <div class="mb-3">
                            <label class="form-label">Gmail Address @</label>
                            <input type="email" class="form-control" placeholder="Name@gmail.com">
                        </div>
                        <div class="mb-3">
                            <label class="form-label">Subject</label>
                            <input type="text" class="form-control" placeholder="Subject">
                        </div>
                        <div class="mb-3">
                            <label class="form-label">Message</label>
                            <textarea name="" class="form-control" placeholder="Write Your Message Here"
                                rows="3"></textarea>
                        </div>
                    </div>
                    <!-- Button trigger modal -->
                    <button type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#exampleModal">
                        Sent Message
                    </button>
                    <!--  message Modal -->
                    <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel"
                        aria-hidden="true">
                        <div class="modal-dialog">
                            <div class="modal-content">
                                <div class="modal-header">
                                    <h1 class="modal-title fs-5" id="exampleModalLabel">Choice Up Says</h1>
                                    <button type="button" class="btn-close" data-bs-dismiss="modal"
                                        aria-label="Close"></button>
                                </div>
                                <div class="modal-body">
                                Hurray your Message have been sent successfully  
                                </div>
                                <div class="modal-footer">
                                    <a href="https://wa.me/03082736787"><button type="button" class="btn btn-success" data-bs-dismiss="modal">Messege on whatsapp</button></a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-md-5 bg-light">
                    <div class="ml-5">
                        <img src="Themes/email.jpg" alt="image" class="image-fluid">
                    </div>
                </div>

            </div>
        </div>
    </div>
    <footer class="bg-dark text-white pb-5 pt-5">
        <div class="container text-center text-md-left">
            <div class="row text-center text-md-left">
                <div class="col-md-3 col-lg-3 col-xl-3 mx-auto mt-3">
                    <a href="home.html"> <img src="CHOICE UP LOGO 2.0.jpg" style="border-radius: 100%;" height="100px"
                            width="125px" alt="reload"></a> <br><br>
                    <small>Choice up Garments Manufacturer, Wholesaler and retailer we Manufacturer all types of
                        knitsware garments , Custom made suits , uniform and we also deal on wholesale and retail all
                        over Pakistan on COD. </small>
                </div>
                <div class="col-md-2 col-lg-2 col-xl-2 mx-auto mt-3">
                    <h5 class="text-uppercase md-4 font-weight-bold text-warning">Products</h5>
                    <p>
                        <a href="catagory-mens.html" class="text-white" style="text-decoration: none;">Mens polo</a>
                    </p>
                    <p>
                        <a href="catagory-mens.html" class="text-white" style="text-decoration: none;">Mens Tee</a>
                    </p>
                    <p>
                        <a href="catalog-women.html" class="text-white" style="text-decoration: none;">Ladies
                            T-Shirts</a>
                    </p>
                    <p>
                        <a href="catalog-kids.html" class="text-white" style="text-decoration: none;">Kids Polo
                            shirts</a>
                    </p>
                    <p>
                        <a href="featured-product.html" class="text-white" style="text-decoration: none;">Top
                            selling</a>
                    </p>
                </div>
                <div class="col-md-3 col-lg-2 col-xl-2 mx-auto mt-3">
                    <h5 class="text-uppercase md-4 font-weight-bold text-warning">Social media Links</h5>
                    <p>
                        <a href="https://www.facebook.com/profile.php?id=100068270438692&mibextid=ZbWKwL" class="text-white" style="text-decoration: none;">Facebook</a>
                    </p>
                    <p>
                        <a href="#" class="text-white" style="text-decoration: none;">Instagram</a>
                    </p>
                    <p>
                        <a href="#" class="text-white" style="text-decoration: none;">Linkedin</a>
                    </p>
                    <p>
                        <a href="https://wa.me/03082736787" class="text-white" style="text-decoration: none;">Contact us
                            on Whatsapp</a>
                    </p>
                </div>
                <div class="col-md-3 col-lg-3 col-xl-3 mx-auto-mt-3">
                    <h5 class="text-uppercase md-4 font-weight-bold text-warning">Our Address</h5>
                    <div class="mapouter">
                        <div class="gmap_canvas"><iframe width="100%" height="100%" id="gmap_canvas"
                                src="https://maps.google.com/maps?q=choice up&t=k&z=12&ie=UTF8&iwloc=&output=embed"
                                frameborder="0" scrolling="no" marginheight="0" marginwidth="0"></iframe><a
                                href="https://2yu.co">2yu</a><br>
                            <style>
                                .mapouter {
                                    position: relative;
                                    text-align: right;
                                    height: 100%;
                                    width: 100%;
                                }
                            </style>
                            <a href="https://embedgooglemap.2yu.co/">html embed google map</a>
                            <style>
                                .gmap_canvas {
                                    overflow: hidden;
                                    background: none !important;
                                    height: 100%;
                                    width: 100%;
                                }
                            </style>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </footer>
   
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js"
        integrity="sha384-kenU1KFdBIe4zVF0s0G1M5b4hcpxyD9F7jL+jjXkk+Q2h455rYXK/7HAuoJl+0I4"
        crossorigin="anonymous"></script>
</body>

</html>