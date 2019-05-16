const MongoClient = require('mongodb').MongoClient;

//connection url

const url = 'mongodb://localhost:27017/myproject';

MongoClient.connect(url, function(err, db) {
    if(err) {
        return console.dir(err);
    }
    console.log('Connected to mongodb');

    // InsertDocuments(db, function() {
    //     db.close();
    // });
    // FindDocuments(db, function(){
    //     db.close();
    // });
    // QueryDocuments(db, function() {
    //     db.close();
    // });
    // UpdateDocument(db, function(){
    //     db.close();
    // });
    FindDocuments(db, function(){
         db.close();
        });
    // RemoveDocument(db, function(){
    //     db.close();
    // });
});

// Insert Single Doc
// const InsertDocument = function(db, callback) {
//     //get Collection
//     const collection = db.collection('users'); //mongodb will create this for us
//     // Insert Docs
//     collection.insert({
//         name: 'Jose Manos',
//         email: 'jose@test.com'
//     }, function(err, result) {
//         if(err) {
//             return console.dir(err);
//         }
//         console.log('Inserted Document');
//         console.log(result);
//         callback(result);
//     });
//}

    // Insert Multiple Docs
// const InsertDocuments = function(db, callback) {
//         // Get Collection
//         const collection = db.collection('users');
//         collection.insertMany([{
//             name: 'John Doe',
//             email: 'john@test.com'
//         },
//         {
//             name: 'Sam Smith',
//             email: 'ssmithn@test.com'
//         },
//         {
//             name: 'Juan Gomez',
//             email: 'jgomez@test.com'
//         }
//     ],
//     function(err, result) {
//         if(err) {
//             return console.dir(err);
//         }
//         console.log('Inserted ' +result.ops.length+' documents');
//         callback(result);
//     });
// }

const FindDocuments = function(db, callback) {
    const collection = db.collection('users');

    collection.find({}).toArray(function(err,docs) {
        if(err) {
            return console.dir(err);
        }
        console.log('Found the following records');
        console.log(docs);
        callback(docs);
    });
}

const QueryDocuments = function(db, callback) {
    // Get Collection
    const collection = db.collection('users');
    collection.find({'name': 'John Doe'}).toArray(function(err,docs) {
        if(err) {
            return console.dir(err);
        }
        console.log('Found the following records');
        console.log(docs);
        callback(docs);
    });
}

const UpdateDocument = function(db, callback) {
    const collection = db.collection('users');
    collection.updateOne({name: 'John Doe'}, {$set: {email: 'john@something.com'}}, function(err, result) {
        if(err) {
            return console.dir(err);
        }
        console.log('Updated Document');
        callback(result);
    });
}

const RemoveDocument = function(db, callback) {
    const collection = db.collection('users');
    collection.deleteOne({name: 'John Doe'}, function(err, result){
        if(err){
            return console.dir(err);
        }
        console.log('Removed Document');
        console.log(result);
        callback(result);
    });
}