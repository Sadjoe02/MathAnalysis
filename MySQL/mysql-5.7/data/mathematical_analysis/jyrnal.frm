TYPE=VIEW
query=select `mathematical_analysis`.`razdel`.`name_razdel` AS `name_razdel`,`mathematical_analysis`.`temi`.`name_temi` AS `name_temi`,`mathematical_analysis`.`users`.`familia` AS `familia`,`mathematical_analysis`.`users`.`name` AS `name`,`mathematical_analysis`.`users`.`otchestvo` AS `otchestvo`,`mathematical_analysis`.`jyrnal_izychenia`.`data_nachala_temi` AS `data_nachala_temi`,ifnull(`mathematical_analysis`.`jyrnal_izychenia`.`data_konca_temi`,\'Тема не окончена\') AS `data_konca_temi` from (((`mathematical_analysis`.`jyrnal_izychenia` join `mathematical_analysis`.`temi` on((`mathematical_analysis`.`jyrnal_izychenia`.`id_temi` = `mathematical_analysis`.`temi`.`id_temi`))) join `mathematical_analysis`.`users` on((`mathematical_analysis`.`jyrnal_izychenia`.`id_users` = `mathematical_analysis`.`users`.`id_users`))) join `mathematical_analysis`.`razdel` on((`mathematical_analysis`.`temi`.`id_razdel` = `mathematical_analysis`.`razdel`.`id_razdel`)))
md5=37716c355a50eebcef8d1e9524e9d50a
updatable=1
algorithm=0
definer_user=root
definer_host=localhost
suid=2
with_check_option=0
timestamp=2024-05-13 16:16:44
create-version=1
source=SELECT\n	  razdel.name_razdel AS name_razdel,\n	  temi.name_temi AS name_temi,\n	  users.familia AS familia,\n	  users.name AS name,\n	  users.otchestvo AS otchestvo,\n	  jyrnal_izychenia.data_nachala_temi AS data_nachala_temi,\n	  IFNULL(jyrnal_izychenia.data_konca_temi, \'Тема не окончена\') AS data_konca_temi\n	FROM jyrnal_izychenia\n	  INNER JOIN temi\n	    ON jyrnal_izychenia.id_temi = temi.id_temi\n	  INNER JOIN users\n	    ON jyrnal_izychenia.id_users = users.id_users\n	  INNER JOIN razdel\n	    ON temi.id_razdel = razdel.id_razdel
client_cs_name=utf8
connection_cl_name=utf8_general_ci
view_body_utf8=select `mathematical_analysis`.`razdel`.`name_razdel` AS `name_razdel`,`mathematical_analysis`.`temi`.`name_temi` AS `name_temi`,`mathematical_analysis`.`users`.`familia` AS `familia`,`mathematical_analysis`.`users`.`name` AS `name`,`mathematical_analysis`.`users`.`otchestvo` AS `otchestvo`,`mathematical_analysis`.`jyrnal_izychenia`.`data_nachala_temi` AS `data_nachala_temi`,ifnull(`mathematical_analysis`.`jyrnal_izychenia`.`data_konca_temi`,\'Тема не окончена\') AS `data_konca_temi` from (((`mathematical_analysis`.`jyrnal_izychenia` join `mathematical_analysis`.`temi` on((`mathematical_analysis`.`jyrnal_izychenia`.`id_temi` = `mathematical_analysis`.`temi`.`id_temi`))) join `mathematical_analysis`.`users` on((`mathematical_analysis`.`jyrnal_izychenia`.`id_users` = `mathematical_analysis`.`users`.`id_users`))) join `mathematical_analysis`.`razdel` on((`mathematical_analysis`.`temi`.`id_razdel` = `mathematical_analysis`.`razdel`.`id_razdel`)))
