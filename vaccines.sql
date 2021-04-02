CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    `MigrationId` VARCHAR(95) NOT NULL,
    `ProductVersion` VARCHAR(32) NOT NULL,
    CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
);

CREATE TABLE `Sangre` (
    `id` INT(11) NOT NULL AUTO_INCREMENT,
    `tipo_sangre` VARCHAR(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
    CONSTRAINT `PK_Sangre` PRIMARY KEY (`id`)
);

CREATE TABLE `Persona` (
    `id` INT(11) NOT NULL AUTO_INCREMENT,
    `Sangre_id` INT(11) NOT NULL,
    `cedula` VARCHAR(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
    `nombre` VARCHAR(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
    `apellido` VARCHAR(25) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
    `telefono` VARCHAR(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
    `correo` VARCHAR(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
    `fecha_nacimiento` DATE NOT NULL,
    `provincia` VARCHAR(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
    `direccion` VARCHAR(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
    `latitud` DOUBLE NOT NULL,
    `longitud` DOUBLE NOT NULL,
    `covid` TINYINT(4) NOT NULL,
    `justificacion` VARCHAR(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`id`, `Sangre_id`),
    CONSTRAINT `fk_Persona_Sangre` FOREIGN KEY (`Sangre_id`) REFERENCES `Sangre` (`id`) ON DELETE RESTRICT
);

CREATE INDEX `fk_Persona_Sangre_idx` ON `Persona` (`Sangre_id`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210401163902_build_database', '3.1.12');

INSERT INTO `Sangre` (`id`, `tipo_sangre`)
VALUES (1, 'O+');
INSERT INTO `Sangre` (`id`, `tipo_sangre`)
VALUES (2, 'O-');
INSERT INTO `Sangre` (`id`, `tipo_sangre`)
VALUES (3, 'A+');
INSERT INTO `Sangre` (`id`, `tipo_sangre`)
VALUES (4, 'A-');
INSERT INTO `Sangre` (`id`, `tipo_sangre`)
VALUES (5, 'B+');
INSERT INTO `Sangre` (`id`, `tipo_sangre`)
VALUES (6, 'B-');
INSERT INTO `Sangre` (`id`, `tipo_sangre`)
VALUES (7, 'AB+');
INSERT INTO `Sangre` (`id`, `tipo_sangre`)
VALUES (8, 'AB-');

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210401164600_`__efmigrationshistory``persona`seed_bloods', '3.1.12');
USE vaccines
SELECT * FROM persona