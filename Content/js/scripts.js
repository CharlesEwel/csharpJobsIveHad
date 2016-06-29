$(document).ready(function(){
  //Responsibility Field ID Number:
  i = 1;
  $(".additional-responsibility").click(function(){
    $(".responsibilityInputDiv").append('<br><label for ="new-responsibility'+i+'">Add a new responsibility</label>'+
                                        '<input id ="new-responsibility'+i+'" name="new-responsibility'+i+'" type="text" required>')
    i ++;
  });
});
