<?php include'relations.php'?>

<body>
<?php include'navigation.php'?>
<nav style="--bs-breadcrumb-divider: '>';" aria-label="breadcrumb">
        <ol class="breadcrumb">
            <li class="breadcrumb-item"><a href="home.php">Home</a></li>
            <li class="breadcrumb-item active" aria-current="page">Kids Collection</li>
        </ol>
    </nav>
    <div id="carouselExamplelight" class="carousel carousel-dark slide" data-bs-ride="carousel">
        <div class="carousel-indicators">
            <button type="button" data-bs-target="#carouselExampleDark" data-bs-slide-to="0" class="active"
                aria-current="true" aria-label="Slide 1"></button>
            <button type="button" data-bs-target="#carouselExampleDark" data-bs-slide-to="1"
                aria-label="Slide 2"></button>
            <button type="button" data-bs-target="#carouselExampleDark" data-bs-slide-to="2"
                aria-label="Slide 3"></button>
        </div>
        <div class="carousel-inner">
            <div class="carousel-item active" data-bs-interval="10000">
                <img src="Themes/sarah-dorweiler-fr0J5-GIVyg-unsplash.jpg" height="450px" class="d-block w-100" alt="">
                <div class="carousel-caption d-none d-md-block">
                    <h5>Summer Flash sale</h5>
                    <p>Some representative placeholder content for the first slide.</p>
                    <button type="button" class="btn btn-success">Click here</button>
                </div>
            </div>
            <div class="carousel-item" data-bs-interval="2000">
                <img src="Themes/priscilla-du-preez-JGyRJlk3idE-unsplash.jpg" height="450px" class="d-block w-100"
                    alt="...">
                <div class="carousel-caption d-none d-md-block" style="color: white;">
                    <h5>Top selling Products</h5>
                    <p>Some representative placeholder content for the second slide.</p>
                    <button type="button" class="btn btn-success">Click here</button>
                </div>
            </div>
            <div class="carousel-item">
                <img src="Themes/connect.avif" height="450px" class="d-block w-100" alt="...">
                <div class="carousel-caption d-none d-md-block" style="color:gold;">
                    <h5>Let's connect through Whatsapp</h5>
                    <p>Click the below link to get connect</p>
                    <button type="button" class="btn btn-success">Click here</button>
                </div>
            </div>
        </div><br>
        <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleDark" data-bs-slide="prev">
            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
            <span class="visually-hidden">Previous</span>
        </button>
        <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleDark" data-bs-slide="next">
            <span class="carousel-control-next-icon" aria-hidden="true"></span>
            <span class="visually-hidden">Next</span>
        </button>
    </div>
    <div class="container">
        <div>
            <h1 class="text-center mb-5 shadow-sm p-3" style="color: gray; ">Comming soon</h1>
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
                        <a href="#" class="text-white" style="text-decoration: none;">Facebook</a>
                    </p>
                    <p>
                        <a href="#" class="text-white" style="text-decoration: none;">Instagram</a>
                    </p>
                    <p>
                        <a href="#" class="text-white" style="text-decoration: none;">Linkedin</a>
                    </p>
                    <p>
                        <a href="#" class="text-white" style="text-decoration: none;">Contact us on Whatsapp</a>
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