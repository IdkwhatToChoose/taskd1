// const express = require('express');
// const bodyParser = require('body-parser');
// const sql = require('mssql');

// const app = express();
// app.use(bodyParser.json());
const express = require('express');
const bodyParser = require('body-parser');
const cors = require('cors'); // Import cors
const sql = require('mssql');

const app = express();
app.use(bodyParser.json());
app.use(cors()); // Use cors

// SQL Server config
const config = {
    server: '127.0.0.1',
    database: 'TaskAPP',
    options: {
        encrypt: true,
        trustServerCertificate: true,
    },
    authentication: {
        type: 'ntlm',
        options: {
            domain: '',
        }
    }
};
app.get('/test-db', async (req, res) => {
    try {
        let pool = await connectToDB();
        res.status(200).send('Database connection successful');
    } catch (err) {
        res.status(500).send('Database connection failed');
    }
});
async function connectToDB() {
    try {
        let pool = await sql.connect(config);
        console.log("Connected to SQL Server");
        return pool;
    } catch (err) {
        console.error("Database connection failed: ", err);
        throw err;
    }
}

app.post('/register', async (req, res) => {
    let email = req.body.email;
    let password = req.body.password;

    try {
        let pool = await connectToDB();
        let request = pool.request();

        request.input('email', sql.VarChar, email);
        request.input('password', sql.VarChar, password);

        const query = `INSERT INTO dbo.RegisteredAccounts (email, password) VALUES (@email, @password)`;

        let result = await request.query(query);

        res.status(200).send('Account registered');
    } catch (err) {
        res.status(500).send('Error registering account');
    } finally {
        sql.close();
    }
});

app.listen(3001, () => {
    console.log('Server is running on port 3001');
});
