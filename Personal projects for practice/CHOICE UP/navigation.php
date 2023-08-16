<?php include 'relations.php';
include('includes/connection.php');
if (session_status() == PHP_SESSION_NONE) {
    session_start();
}
?>

<body>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js"
        integrity="sha384-kenU1KFdBIe4zVF0s0G1M5b4hcpxyD9F7jL+jjXkk+Q2h455rYXK/7HAuoJl+0I4"
        crossorigin="anonymous"></script>
    <nav class="navbar navbar-expand-lg " style="background-image:url(Themes/na.jpg)">
        <nav class="navbar bg-light" style="background-image:url(Themes/na.jpg);margin-top:-8px;">
            <div class="container" style="color: w;">
                <a class="navbar-brand" href="home.php">
                    <img src="about images\l-removebg-preview.png" alt="Logo" width="120" height="90">
                </a>
            </div>
        </nav>
        <a class="navbar-brand" href="Admin_area\admin.php" id="navigation">Home</a>
        <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent"
            aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarSupportedContent">
            <ul class="navbar-nav me-auto mb-2 mb-lg-0">
                <li class="nav-item dropdown">
                    <a class="nav-link dropdown-toggle" href="" role="button" data-bs-toggle="dropdown"
                        aria-expanded="false" id="navigation">
                        Catagory
                    </a>
                    <ul class="dropdown-menu bg-primary ">
                        <?php getcatagories(); ?>
                    </ul>
                </li>
                <li class="nav-item">
                    <a class="nav-link active" aria-current="page" href="user_profile.php" id="navigation"><i
                            class="fa-regular fa-user fa-xl" style="color: #fbff00;"></i></a>
                </li>
                <li class="nav-item">
                    <a class="nav-link active" aria-current="page" href="featured-product.php" id="navigation">Freatured
                        Products</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" id="navigation" href="about.php">About us</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" id="navigation" href="contact.php"> Contact us</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" id="navigation" href="my_cart.php"> <i
                            class="fa-sharp fa-solid fa-cart-shopping fa-xl"></i><sup>
                            <?php get_cart_items_qty() ?>
                        </sup></a>
                </li>

                <li class="nav-item">
                    <a class="nav-link nav-link-success " id="navigation" href="#">Total Shopping/-
                        <?php get_total_cart_price() ?>
                    </a>
                </li>
            </ul>
            <div class="d-flex align-items-center ml-0">
                <ul class="navbar-nav me-auto mb-2 mb-lg-0">
                    <li class="nav-item">
                        <form class="d-flex" role="search" action="search_product.php" method="get">
                            <input class="form-control me-2" type="search" name="search_data" placeholder="Search"
                                aria-label="Search">
                            <button class="btn btn-outline-warning me-2" value="search" name="search_data_btn"
                                type="submit">Search</button>
                        </form>
                    </li>
                    <li class="nav-item me-2 ">
                        <a href="login.php"> <button class="nav-link btn  btn-dark" id="navigation">Login</button></a>
                    </li>
                    <li class="nav-item ">
                        <a href="signup.php"><button class="nav-link btn btn-danger " id="navigation">Sign
                                Up</button></a>
                    </li>
                </ul>
            </div>

        </div>
        </div>

    </nav>
    <nav class="navbar navbar-expand-lg navbar-dark bg-secondary d-flex" s>
        <ul class="navbar-nav me-auto">
            <?php
            if (isset($_SESSION['user_name'])) {
                echo '<li class="nav-item"><a class="nav-link" href="#">Welcome ' . $_SESSION['user_name'] . '</a></li>';
            } else {
                echo '<li class="nav-item"><a class="nav-link" href="login.php">Wellcome Guest</a></li>';
            }
            ?>
            <?php
            if (isset($_SESSION['user_name'])) {
                echo '<li class="nav-item"><a class="nav-link" href="logout.php">Logout</a></li>';
            } else {
                echo '<li class="nav-item"><a class="nav-link" href="login.php">Login</a></li>';
            }
            ?>

        </ul>
    </nav>