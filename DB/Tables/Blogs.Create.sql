-- Blogs Table ========================
CREATE TABLE Blogs (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    BlogTitle nvarchar(200)  NOT NULL,
    BlogContent nvarchar(MAX)  NOT NULL,
    ViewCount int  NULL
);

