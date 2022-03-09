
--Primera ejecución
INSERT INTO [dbo].[Status] VALUES ('Abierto'), ('Cerrado')


--Segunda ejecución
INSERT INTO [dbo].[Users] VALUES ('Alan', 'Sierra'), ('Samir', 'Muñoz')


--Ejecución final
INSERT INTO [dbo].[Tickets] VALUES (1, GETDATE(), NULL, 1, 'Primer ticket')
