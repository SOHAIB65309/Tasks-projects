<?php include('relations.php'); ?>
<body>
    <div class="container-fluid p-0"></div>
<nav class="navbar navbar-light bg-dark">
  <div class="container">
    <a class="navbar-brand" href="#">
      <img src="l-removebg-preview.png" style="margin-left: 115%;" alt="" width="300" height="200">
    </a>
  </div>
</nav>
<div class="bg-light "> <h2 class="text-center p2">Manage store</h2> </div>
   <div class="row">
    <div class="col-md-12 bg-secondary p-1 d-flex">
        <div>
            <a href="#"> <img src="CHOICE_UP_LOGO_2.0-removebg-preview.png" style="width: 150px; object-fit:contain;" alt=""> </a>
        </div>
   
        <div class="mx-2 mt-4 text-center p-2">
                <button class="btn btn-dark mt-2"><a href="insert_products.php">Insert Products</a></button>
                <button class="btn btn-dark mt-2"><a href="admin.php?view_products">View Products</a></button>
                <button class="btn btn-dark mt-2"><a href="admin.php?insert_Catagories">Insert Catagories</a></button>
                <button class="btn btn-dark mt-2"><a href="admin.php?view_catagories">View Catagories</a></button>
                <button class="btn btn-dark mt-2"><a href="admin.php?insert_colours">Colours Combination </a></button>
                <button class="btn btn-dark mt-2"><a href="admin.php?order_log">Orders Log</a></button>
                <button class="btn btn-dark mt-2"><a href="#">Payments Log</a></button>
                <button class="btn btn-dark mt-2"><a href="#">Customers Details</a></button>
                <button class="btn btn-dark mt-1 " ><a href="#">Log out</a></button>
            </div>
    </div>
</div>
<div class="container my-5">
<?php
  if (isset($_GET['order_log']))
  {
echo
'
<div class="mx-2 mt-4 text-center p-2">
    <a href="admin.php?pending_orders" class="btn btn-dark mt-2">Pending Orders</a>
    <a href="admin.php?handled_orders" class="btn btn-dark mt-2">Handled Orders</a>
</div>';
  }
  ?>
  <?php
  if (isset($_GET['insert_Catagories']))
  {
 include('insert_catagories.php');
  }
  ?>
    <?php
  if (isset($_GET['insert_colours']))
  {
 include('insert_colours.php');
  }
  if (isset($_GET['view_products']))
  {
 include('view_products.php');
  }
  if (isset($_GET['view_catagories']))
  {
 include('view_catagories.php');
  } 
  ?>
</div>
<?php include'footer.php'?>
</body>