
<?php include('../includes/connection.ph`p');?>
<div class="container my-5">
    <?php
    if (isset($_GET['pending_orders']))
    {
        echo
        '
        <form action="" method="post">
    <div class="row ">
        <div class="col-md-2">
            <div class="form-group">
                <label for="date_range">Select Date Range:</label>
                <select class="form-control" id="date_range" name="date_range">
                    <option value="7">Last 7 Days</option>
                    <option value="15">Last 15 Days</option>
                    <option value="30">Last 30 Days</option>
                    <option value="90">Last 3 Months</option>
                    <option value="180">Last 6 Months</option>
                    <option value="365">Last 1 Year</option>
                </select>
            </div>
        </div>

    <div class="col-md-2">
        <div class="form-group">
            <label for="start_date">Start Date:</label>
            <input type="date" id="start_date" class="form-control" name="start_date" required>
        </div>
    </div>
    <div class="col-md-2">
        <div class="form-group">
            <label for="end_date">End Date:</label>
            <input type="date" id="end_date" class="form-control" name="end_date" required>
        </div>
    </div>
    </div>
    <div class="text-center my-2">
        <input type="submit" value="Filter Orders" name="filter_orders" class="btn btn-success">
    </div>
</form>
        ';
    } 
    elseif (isset($_GET['handled_orders']))
     {
        include('handled_orders.php');
    }
    ?>
</div>