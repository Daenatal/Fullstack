var express = require('express');
var bodyParser = require('body-parser');
var path = require('path');
//var pug = require('pug'); commenting out to use an alternative

var port= 3000;

var app = express();

app.use(function(req, res, next) {
    console.log('Time: ', Date.now());
    next();
}); //custom middleware, all this is how we call middleware

//app.set('view engine', 'pug'); //setting view engine for pug, creating views directory with .pug files

app.set('view engine', 'ejs');
app.set('views', path.join(__dirname, 'views'));

app.use(bodyParser.json());
app.use(bodyParser.urlencoded({extended: false}));
app.use(express.static(path.join(__dirname, 'public'))); //this lets us add a directory for static files

app.get('/', function(req, res){
    //res.send('Hello World!'); replacing with .render for pug usage
    res.render('index', {
        title: 'Hello World', //using an orm we can pass in data from a database
        showTitle: true,
        people: ['John', 'Stefan', 'Roger']
    });
}); //also have post, put, delete requests

app.get('/about', function(req, res){
    res.render('about');
});

app.get('/contact', function(req, res){
    res.render('contact');
});

app.listen(3000);
console.log('Server started on port 3000');

module.exports = app;