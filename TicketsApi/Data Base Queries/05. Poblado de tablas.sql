
--Primera ejecuci�n
INSERT INTO [dbo].[Status] VALUES ('Abierto'), ('Cerrado')


--Segunda ejecuci�n
INSERT INTO [dbo].[Users] VALUES ('Alan', 'Sierra'), ('Samir', 'Mu�oz')


--Ejecuci�n final
INSERT INTO [dbo].[Tickets] VALUES (1, GETDATE(), NULL, 1, 'Primer ticket')
