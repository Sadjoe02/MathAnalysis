TYPE=VIEW
query=select `mathematical_analysis`.`razdel`.`name_razdel` AS `name_razdel`,`mathematical_analysis`.`tests`.`id_test` AS `id_test`,`mathematical_analysis`.`tests`.`name_test` AS `name_test`,`mathematical_analysis`.`yrovni`.`name_yrov` AS `name_yrov`,`mathematical_analysis`.`temi`.`name_temi` AS `name_temi` from (((`mathematical_analysis`.`temi` join `mathematical_analysis`.`razdel` on((`mathematical_analysis`.`temi`.`id_razdel` = `mathematical_analysis`.`razdel`.`id_razdel`))) join `mathematical_analysis`.`tests` on((`mathematical_analysis`.`tests`.`id_temi` = `mathematical_analysis`.`temi`.`id_temi`))) join `mathematical_analysis`.`yrovni` on((`mathematical_analysis`.`tests`.`id_yrovni` = `mathematical_analysis`.`yrovni`.`id_yrovni`)))
md5=7f82b336525c0aea425342a119d37a59
updatable=1
algorithm=0
definer_user=root
definer_host=localhost
suid=2
with_check_option=0
timestamp=2024-03-27 11:15:44
create-version=1
source=SELECT\n  `razdel`.`name_razdel` AS `name_razdel`,\n  `tests`.`id_test` AS `id_test`,\n  `tests`.`name_test` AS `name_test`,\n  `yrovni`.`name_yrov` AS `name_yrov`,\n  `temi`.`name_temi` AS `name_temi`\nFROM (((`temi`\n  JOIN `razdel`\n    ON ((`temi`.`id_razdel` = `razdel`.`id_razdel`)))\n  JOIN `tests`\n    ON ((`tests`.`id_temi` = `temi`.`id_temi`)))\n  JOIN `yrovni`\n    ON ((`tests`.`id_yrovni` = `yrovni`.`id_yrovni`)))
client_cs_name=utf8
connection_cl_name=utf8_general_ci
view_body_utf8=select `mathematical_analysis`.`razdel`.`name_razdel` AS `name_razdel`,`mathematical_analysis`.`tests`.`id_test` AS `id_test`,`mathematical_analysis`.`tests`.`name_test` AS `name_test`,`mathematical_analysis`.`yrovni`.`name_yrov` AS `name_yrov`,`mathematical_analysis`.`temi`.`name_temi` AS `name_temi` from (((`mathematical_analysis`.`temi` join `mathematical_analysis`.`razdel` on((`mathematical_analysis`.`temi`.`id_razdel` = `mathematical_analysis`.`razdel`.`id_razdel`))) join `mathematical_analysis`.`tests` on((`mathematical_analysis`.`tests`.`id_temi` = `mathematical_analysis`.`temi`.`id_temi`))) join `mathematical_analysis`.`yrovni` on((`mathematical_analysis`.`tests`.`id_yrovni` = `mathematical_analysis`.`yrovni`.`id_yrovni`)))
