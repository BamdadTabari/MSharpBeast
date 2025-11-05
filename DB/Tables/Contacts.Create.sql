-- Contacts Table ========================
CREATE TABLE Contacts (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    Category uniqueidentifier  NOT NULL,
    FirstName nvarchar(200)  NOT NULL,
    LastName nvarchar(200)  NOT NULL,
    PhoneNumber nvarchar(200)  NOT NULL,
    Email nvarchar(200)  NULL
);

