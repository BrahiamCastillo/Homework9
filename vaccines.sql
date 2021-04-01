CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    `MigrationId` varchar(95) NOT NULL,
    `ProductVersion` varchar(32) NOT NULL,
    CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
);

CREATE TABLE `Sangre` (
    `id` int(11) NOT NULL AUTO_INCREMENT,
    `tipo_sangre` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
    CONSTRAINT `PK_Sangre` PRIMARY KEY (`id`)
);

CREATE TABLE `Persona` (
    `id` int(11) NOT NULL AUTO_INCREMENT,
    `Sangre_id` int(11) NOT NULL,
    `cedula` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
    `nombre` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
    `apellido` varchar(25) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
    `telefono` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
    `correo` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
    `fecha_nacimiento` date NOT NULL,
    `provincia` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
    `direccion` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
    `latitud` double NOT NULL,
    `longitud` double NOT NULL,
    `covid` tinyint(4) NOT NULL,
    `justificacion` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
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
VALUES ('20210401164600_seed_bloods', '3.1.12');