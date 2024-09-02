function RegisterWindow() {
    document.getElementById('mainWindow').style.display = 'block';
    document.getElementById('overlay').style.display = 'block';
}

// Function to hide the registration window and overlay
function CloseWindow() {
    document.getElementById('mainWindow').style.display = 'none';
    document.getElementById('overlay').style.display = 'none';
}
// db.js
const sql = require('mssql');

// Configuration for the SQL Server connection
const config = {
    server: '127.0.0.1', // for example 'localhost' or '127.0.0.1'
    database: 'Tasky',
    options: {
        encrypt: true, // Use this if you're connecting to Azure
        trustServerCertificate: true, // This may be needed for local testing
    }
};

// Connect to SQL Server
async function connectToDB() {
    try {
        await sql.connect(config);
        console.log("Connected to SQL Server");
    } catch (err) {
        console.error("Database connection failed: ", err);
    }
}

module.exports = {
    sql,
    connectToDB,
};


