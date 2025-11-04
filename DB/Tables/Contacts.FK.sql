ALTER TABLE Contacts ADD Constraint
                [FK_Contact.Category]
                FOREIGN KEY (Category)
                REFERENCES Categories (ID)
                ON DELETE NO ACTION;
GO