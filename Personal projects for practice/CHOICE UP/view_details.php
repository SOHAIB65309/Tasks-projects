<?php
include('includes/connection.php');
include('functions/common_functions.php');
?>
<?php include('relations.php')?>
<body>
    <?php include('navigation.php')?>
<div class="row">
  <div class="col-md-10">
            <!--products--->
        <div class="row"> 
            <?php
show_product_details();
get_unique_catagory();
echo"<div class='text-center'>
<a href='featured-product.php'><button type='button'  class='btn btn-primary p-2 my-2'>View more</button></a>
</div>";
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

    