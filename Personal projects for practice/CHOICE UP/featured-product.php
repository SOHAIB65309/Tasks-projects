<?php
include('includes/connection.php');
include('functions/common_functions.php');
?>
<?php include'relations.php'?>
<body>
    <?php include'navigation.php'?>
    <nav style="--bs-breadcrumb-divider: '>';" aria-label="breadcrumb">
        <ol class="breadcrumb">
          <li class="breadcrumb-item"><a href="home.php" style="text-decoration: none;">Home</a></li>
        </ol>
      </nav>
   <div id="carouselExampleInterval" class="carousel slide carousel-dark " data-bs-ride="carousel">

        <div class="carousel-inner">
            <div class="carousel-item active" data-bs-interval="10000">
                <img src="Themes/sarah-dorweiler-fr0J5-GIVyg-unsplash.jpg" height="450px" style="width: 70%;margin-left: auto;margin-right: auto;" class="d-block " alt="">
                <div class="carousel-caption d-none d-md-block text-center" style="padding: 0%;">
                    <h5 class="text-center">Summer Flash sale</h5>
                    <p>Summer flash sale is live now </p>
                    <button type="button" class="btn btn-success">Click here</button>
                </div>
               
            </div>
            <div class="carousel-item" data-bs-interval="2000">
                <img src="Themes/priscilla-du-preez-JGyRJlk3idE-unsplash.jpg" height="450px" class="d-block w-100"
                    alt="...">
                <div class="carousel-caption d-none d-md-block" style="color: white;">
                    <h5>Top selling Products</h5>
                    <p>Tap here to check our top selling procucts </p>
                   <a href="featured-product.html"> <button type="button" class="btn btn-success">Click here</button></a>
                </div>
            </div>
            <div class="carousel-item">
                <img src="Themes/connect.avif" height="450px" class="d-block w-100" alt="...">
                <div class="carousel-caption d-none d-md-block" style="color:gold;">
                    <h5>Let's connect through Whatsapp</h5>
                    <p>Click the below link to get connect</p>
                    <a href="https://wa.me/03082736787"><button type="button" class="btn btn-success">Click
                            here</button></a>
                </div>
            </div>
        </div>

        <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleInterval"
        data-bs-slide="prev">
        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
        <span class="visually-hidden">Previous</span>
    </button>
    <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleInterval"
        data-bs-slide="next">
        <span class="carousel-control-next-icon" aria-hidden="true"></span>
        <span class="visually-hidden">Next</span>
    </button>
    </div>
    <div class="container">
        <div>
            <h2 class="text-center mb-5 shadow-sm p-3" style="color: gray; ">Hot selling</h2>
        </div>
    </div>
<div class="row">
  <div class="col-md-10">
            <!--products--->
        <div class="row"> 
            <?php
view_all_products();
get_unique_catagory();
            ?>
       </div>
        </div>
            <div class="col-md-2 bg-primary p-0">
                <ul class="navbar-nav my-auto text-center">
                    <li class="navbar-items bg-success p-2">
                        <a class="nav-link text-light" href="">Catagories
                        </a>
                    </li>
            
            <?php
getcatagories();

            ?>
                    </ul>
            </div>
    </div>
<?php include'footer.php' ?>
</body>

    