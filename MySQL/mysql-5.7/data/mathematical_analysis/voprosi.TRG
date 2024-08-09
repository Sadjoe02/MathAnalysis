TYPE=TRIGGERS
triggers='CREATE DEFINER=`root`@`localhost` TRIGGER delete_question\n	BEFORE DELETE\n	ON voprosi\n	FOR EACH ROW\nBEGIN\nIF @DISABLE_TRIGGER IS NULL THEN\n  -- Удаляем ошибки, связанные с вопросами тестов удаляемой темы\n  DELETE osh\n    FROM mathematical_analysis.oshibki osh\n  WHERE osh.id_vopr = OLD.id_vopr;\n\n  -- Удаляем записи из таблицы \'otveti\', связанные с вопросами\n  DELETE ot\n    FROM mathematical_analysis.otveti ot\n  WHERE ot.id_vopr = OLD.id_vopr;\n\n  -- Удаляем связи между тестами и вопросами\n   DELETE\n     FROM mathematical_analysis.voprosi_testov\n   WHERE id_vopr = OLD.id_vopr;\n    END IF;\nEND'
sql_modes=1436549152
definers='root@localhost'
client_cs_names='utf8'
connection_cl_names='utf8_general_ci'
db_cl_names='utf8mb4_general_ci'
created=171846939133
