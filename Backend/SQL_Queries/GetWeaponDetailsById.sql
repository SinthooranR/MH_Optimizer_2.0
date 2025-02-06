CREATE PROCEDURE GetWeaponDetailsById
	@WeaponId INT
AS
BEGIN

    SELECT * FROM Weapon
    WHERE Weapon_Id = @WeaponId;
	IF EXISTS (
        SELECT 1 
        FROM Weapon 
		WHERE Name = (SELECT Name FROM Weapon WHERE Weapon_Id = @WeaponId) AND Weapon_Type NOT IN ('bow', 'light-bowgun', 'heavy-bowgun')
    )
	BEGIN
		SELECT * FROM Weapon_Sharpness WHERE Name = (SELECT Name FROM Weapon WHERE Weapon_Id = @WeaponId)
	END
   

    IF EXISTS (
        SELECT 1 
        FROM Weapon 
        WHERE Weapon_Id = @WeaponId AND Weapon_Type = 'bow'
    )
    BEGIN
        SELECT * FROM Weapon_Bow
        WHERE Name = (SELECT Name FROM Weapon WHERE Weapon_Id = @WeaponId);
    END

	IF EXISTS (
		SELECT 1 
		FROM Weapon 
		WHERE Weapon_Id = @WeaponId AND Weapon_Type = 'insect-glaive'
	)
	BEGIN
		SELECT * FROM Weapon_Kinsect
		SELECT * FROM Weapon_Kinsect_Craft
	END

	IF EXISTS (
		SELECT 1 
		FROM Weapon 
		WHERE Weapon_Id = @WeaponId AND (Weapon_Type = 'light-bowgun' OR Weapon_Type = 'heavy-bowgun')
	)
	BEGIN
		SELECT * FROM Weapon_Ammo
		WHERE [Key] = (SELECT Ammo_Config FROM Weapon WHERE Weapon_Id = @WeaponId)

	END
END