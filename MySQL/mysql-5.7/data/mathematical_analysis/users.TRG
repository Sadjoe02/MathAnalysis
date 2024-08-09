TYPE=TRIGGERS
triggers='CREATE DEFINER=`root`@`localhost` TRIGGER delete_user\n	BEFORE DELETE\n	ON users\n	FOR EACH ROW\nBEGIN\n  DELETE osh\n    FROM mathematical_analysis.oshibki osh\n      INNER JOIN mathematical_analysis.popitki pop\n        ON osh.id_popitka = pop.id_popitka\n  WHERE pop.id_users = OLD.id_users;\n\n  -- Удаляем попытки\n  DELETE pop\n    FROM mathematical_analysis.popitki pop\n  WHERE pop.id_users = OLD.id_users;\n\n  -- Удаляем записи из \'jyrnal_izychenia\'\n  DELETE ji\n    FROM mathematical_analysis.jyrnal_izychenia ji\n  WHERE ji.id_users = OLD.id_users;\nEND'
sql_modes=1436549152
definers='root@localhost'
client_cs_names='utf8'
connection_cl_names='utf8_general_ci'
db_cl_names='utf8mb4_general_ci'
created=171756949314
