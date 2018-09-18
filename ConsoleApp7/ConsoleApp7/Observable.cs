<html>
<!-- <script src = "https://cdnjs.cloudflare.com/ajax/libs/rxjs/6.3.2/rxjs.umd.js" ></ script > -->
    < script src="https://unpkg.com/@reactivex/rxjs@5.3.0/dist/global/Rx.js"></script>

<script>
function testingKey(event)
{
< !--var Observable = require('rxjs/Observable').Observable; -->
var dd = "[^~,][^~,]*";

< !-- if (/[1 - 9] / g.test(event.key))
    {
        -->

< !--console.log(event.key + "number"); -->
< !-- }
    -->


< !-- < !--var status = dd.test(event.key); --> -->


< !-- if (/[^ 0 - 9a - bA - B\s] / gi.test(event.key))
    {
        -->
< !--console.log("stroig"); -->
< !-- < !--console.log("ss" + typeof(event.key)); --> -->
< !-- }
    -->

var ss = Rx;
    if (/\s / g.test(event.key) || /[-!$%^ &*()_ +| ~=`{ }\[\]:\/;<>?,.@#]/.test(event.key)){
console.log(event.key);
console.log("special");
}
else if(/[1-9]/g.test(event.key)){
    console.log(event.key + "number");
}
else{
    console.log("stroig");
}
var promise = new Promise((resolve, reject) => {
    setTimeout(() => {
        resolve(event.key)
        }, 1000)
    });

  var obsvPromise = Rx.Observable.fromPromise(promise);
obsvPromise.filter(key => (/\s/g.test(key))).subscribe(result => console.log(result));
    <!-- obsvPromise.subscribe(result => console.log(result)) -->
<!-- var source = Rx.Observable; -->
   
<!-- var subscription = source.subscribe(-->
    < !--function(x) { -->
        < !--console.log('Next: ' + x); -->
    <!-- }, -->
    <!-- function(err)
{
    -->

< !--console.log('Error: ' + err); -->

< !-- }, -->
    <!-- function()
{
    -->

< !--console.log('Completed'); -->

< !-- }); -->

}
</script>
<div>dsjbkj</div>
<input type = 'text'  onKeyPress='testingKey(event)' />
</html>