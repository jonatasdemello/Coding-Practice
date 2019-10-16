function Field(val) {
  this.value = val;
}

Field.prototype.validate = function () {
  return this.value.length > 0;
}

var username = new Field("myuser");
var password = new Field("pass");

var fields = [username, password];

var formIsValid = fields.every(function (f) {
  return f.validate();
});

console.log(formIsValid);
