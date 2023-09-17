CREATE TABLE `User` (
  `username` varchar(255) PRIMARY KEY NOT NULL,
  `password` varchar(255) NOT NULL,
  `email` varchar(255) UNIQUE NOT NULL,
  `n_tel` varchar(255) UNIQUE NOT NULL,
  `n_c` varchar(255) NOT NULL,
  `d_birth` date,
  `role` varchar(255) NOT NULL COMMENT 'Role at work',
  `role_user` integer NOT NULL DEFAULT "4" COMMENT 'Role inside the app',
  `h_w` double(12, 10) NOT NULL COMMENT 'Hourly wage',
  `h_s_c` double(12, 10) NOT NULL COMMENT 'Hourly service cost',
  `shifts` varchar(255) NOT NULL,
  `id_m` integer COMMENT 'Id of the managment'
);

CREATE TABLE `Managment` (
  `id` integer PRIMARY KEY NOT NULL,
  `name` varchar(255) NOT NULL,
  `logo` varchar(255) NOT NULL DEFAULT "path/to/EvoSpan/logo/logo.png",
  `theme` integer NOT NULL DEFAULT 1
);

CREATE TABLE `Archive` (
  `id` varchar(255) PRIMARY KEY NOT NULL,
  `name` varchar(255) NOT NULL,
  `id_m` integer NOT NULL COMMENT 'Id of the managment',
  `creation` datetime,
  `last_upd` timestamp
);

CREATE TABLE `Warehouse` (
  `id` varchar(255) PRIMARY KEY NOT NULL,
  `id_a` varchar(255) NOT NULL COMMENT 'Id of the archive',
  `products` longtext
);

CREATE TABLE `Activities` (
  `id` varchar(255) PRIMARY KEY NOT NULL,
  `id_a` varchar(255) NOT NULL COMMENT 'Id of the archive',
  `name` varchar(255) NOT NULL,
  `id_u` varchar(255) NOT NULL DEFAULT "{'id_user':null}",
  `i_r` text DEFAULT "{null:null}",
  `orders` text DEFAULT "{null:null}",
  `quotes` text DEFAULT "{null:null}",
  `bills` text DEFAULT "{null:null}"
);

ALTER TABLE `User` ADD FOREIGN KEY (`id_m`) REFERENCES `Managment` (`id`) ON DELETE CASCADE ON UPDATE NO ACTION;

ALTER TABLE `Archive` ADD FOREIGN KEY (`id_m`) REFERENCES `Managment` (`id`) ON DELETE CASCADE ON UPDATE NO ACTION;

ALTER TABLE `Warehouse` ADD FOREIGN KEY (`id_a`) REFERENCES `Archive` (`id`) ON DELETE CASCADE ON UPDATE NO ACTION;

ALTER TABLE `Activities` ADD FOREIGN KEY (`id_a`) REFERENCES `Archive` (`id`) ON DELETE CASCADE ON UPDATE NO ACTION;
