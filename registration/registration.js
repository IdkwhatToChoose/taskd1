// const sql = require('mssql');

// // Configuration for the SQL Server connection
// const config = {
//     server: '127.0.0.1', // for example 'localhost' or '127.0.0.1'
//     database: 'TaskAPP',
//     options: {
//         encrypt: true, // Use this if you're connecting to Azure
//         trustServerCertificate: true, // This may be needed for local testing
//     },
//     authentication: {
//         type: 'ntlm',
//         options: {
//             domain: '', // Leave blank for the local machine
//             userName: '', // Leave blank to use the currently logged-in user
//             password: '', // Leave blank when using Windows Authentication
//         }
//     }
// };

// // Connect to SQL Server
// async function connectToDB() {
//     try {
//         let pool = await sql.connect(config);
//         console.log("Connected to SQL Server");
//         return pool;
//     } catch (err) {
//         console.error("Database connection failed: ", err);
//         throw err;
//     }
// }

// async function registerAccount() {
//     let email = document.getElementById("email").value;
//     let password = document.getElementById("password").value;
// console.log(email);
//     try {
//         let pool = await connectToDB();
//         let request = pool.request();

//         request.input('email', sql.VarChar, email);
//         request.input('password', sql.VarChar, password);

//         // Create the SQL query
//         const query = `INSERT INTO dbo.RegisteredAccounts (email, password)
//                        VALUES (@email, @password)`;
        
//         // Execute the query
//         let result = await request.query(query);
        
//         console.log('Account registered:', result);
//     } catch (err) {
//         console.error('Error registering account:', err);
//     } finally {
//         sql.close(); // Close the connection
//     }
// }
