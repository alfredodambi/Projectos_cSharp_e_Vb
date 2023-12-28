--USE [master]
--GO

--IF DB_ID('dapper_test1') IS NULL
--	BEGIN
--		CREATE DATABASE [dapper_test1]
--		PRINT 'DATABASE CREATED'
--	END
--ELSE
--	BEGIN
--		PRINT 'UNABLE TO CREATE DATABASE'
--	END
--GO

--USE [dapper_test1]
--GO

BEGIN TRY
    -- Is it in the right place?
	BEGIN TRANSACTION

	-- Create the Borrowers table
    IF OBJECT_ID('Borrowers') IS NULL
        BEGIN
            CREATE TABLE Borrowers (
                [Id] INT PRIMARY KEY IDENTITY(1,1)  NOT NULL,
                Name NVARCHAR(100) NOT NULL
            );
            PRINT 'Borrowers table created successfully.'
        END
    ELSE
        BEGIN
            PRINT 'Borrowers table already exists.'
        END

    -- Create the Books table
    IF OBJECT_ID('Books') IS NULL
        BEGIN
            CREATE TABLE Books (
                [Id] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
                [Title] NVARCHAR(100) NOT NULL,
                [Author] NVARCHAR(100) NOT NULL,
                [IsAvailable] BIT NOT NULL DEFAULT 1
            );
            PRINT 'Books table created successfully.'
        END
    ELSE
        BEGIN
            PRINT 'Books table already exists.'
        END

    -- Create the Loans table
    IF OBJECT_ID('Loans') IS NULL
        BEGIN
            CREATE TABLE Loans (
                [Id] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
                [Book_Id] INT NOT NULL,
                [Borrower_Id] INT NOT NULL,
                [StartDate] DATETIME NOT NULL,
                [ExpiryDate] DATETIME NOT NULL,
                [ReturnedOn] DATETIME NULL,

                FOREIGN KEY (Book_Id) REFERENCES Books (Id),
                FOREIGN KEY (Borrower_Id) REFERENCES Borrowers (Id)
            );
            PRINT 'Loans table created successfully.'
        END
    ELSE
        BEGIN
            PRINT 'Loans table already exists.'
        END

    COMMIT TRANSACTION
    PRINT 'Database and tables created successfully.'
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
	PRINT 'SOMETHING WENT WRONG' + ERROR_MESSAGE()
END CATCH