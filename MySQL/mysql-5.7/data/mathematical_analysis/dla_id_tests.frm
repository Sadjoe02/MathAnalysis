TYPE=VIEW
query=select `mathematical_analysis`.`temi`.`name_temi` AS `name_temi`,`mathematical_analysis`.`tests`.`id_temi` AS `id_temi`,`mathematical_analysis`.`tests`.`id_test` AS `id_test`,`mathematical_analysis`.`tests`.`name_test` AS `name_test` from (`mathematical_analysis`.`tests` join `mathematical_analysis`.`temi` on((`mathematical_analysis`.`tests`.`id_temi` = `mathematical_analysis`.`temi`.`id_temi`)))
md5=ddd5c5ff945433fb602fab06324a4e96
updatable=1
algorithm=0
definer_user=root
definer_host=localhost
suid=2
with_check_option=0
timestamp=2024-03-27 11:15:44
create-version=1
source=SELECT\n  `temi`.`name_temi` AS `name_temi`,\n  `tests`.`id_temi` AS `id_temi`,\n  `tests`.`id_test` AS `id_test`,\n  `tests`.`name_test` AS `name_test`\nFROM (`tests`\n  JOIN `temi`\n    ON ((`tests`.`id_temi` = `temi`.`id_temi`)))
client_cs_name=utf8
connection_cl_name=utf8_general_ci
view_body_utf8=select `mathematical_analysis`.`temi`.`name_temi` AS `name_temi`,`mathematical_analysis`.`tests`.`id_temi` AS `id_temi`,`mathematical_analysis`.`tests`.`id_test` AS `id_test`,`mathematical_analysis`.`tests`.`name_test` AS `name_test` from (`mathematical_analysis`.`tests` join `mathematical_analysis`.`temi` on((`mathematical_analysis`.`tests`.`id_temi` = `mathematical_analysis`.`temi`.`id_temi`)))
