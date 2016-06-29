$(document).ready(function(){
  //Responsibility Field ID Number:
  i = 1;
  $(".additional-responsibility").click(function(){
    $("#responsibilityInputDiv").append('<br><label for ="responsibility-description'+i+'">Add a new responsibility</label>'+
    '<input id ="responsibility-description'+i+'" name="responsibility-description'+i+'" type="text" required>');
    $("#number-of-responsibilities").val(i+1);
    i ++;
  });

  $("#job-form").submit(function(){
    var responsibilities=[];
    $(".new-address").each(function() {
      var responsibilityDescription = $(this).find(".responsibility-description").val();;
      responsibilities.push(newAddress);
    });
  });
});
