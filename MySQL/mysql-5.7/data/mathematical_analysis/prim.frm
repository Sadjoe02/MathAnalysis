TYPE=VIEW
query=select `mathematical_analysis`.`konspetti_primerov`.`konspekt_primera` AS `konspekt_primera`,`mathematical_analysis`.`temi`.`name_temi` AS `name_temi`,`mathematical_analysis`.`razdel`.`name_razdel` AS `name_razdel` from ((`mathematical_analysis`.`konspetti_primerov` join `mathematical_analysis`.`temi` on((`mathematical_analysis`.`konspetti_primerov`.`id_temi` = `mathematical_analysis`.`temi`.`id_temi`))) join `mathematical_analysis`.`razdel` on((`mathematical_analysis`.`temi`.`id_razdel` = `mathematical_analysis`.`razdel`.`id_razdel`)))
md5=fbc92f71c4cd70d98fac26ada4262faf
updatable=1
algorithm=0
definer_user=root
definer_host=localhost
suid=2
with_check_option=0
timestamp=2024-03-27 11:15:44
create-version=1
source=SELECT\n  `konspetti_primerov`.`konspekt_primera` AS `konspekt_primera`,\n  `temi`.`name_temi` AS `name_temi`,\n  `razdel`.`name_razdel` AS `name_razdel`\nFROM ((`konspetti_primerov`\n  JOIN `temi`\n    ON ((`konspetti_primerov`.`id_temi` = `temi`.`id_temi`)))\n  JOIN `razdel`\n    ON ((`temi`.`id_razdel` = `razdel`.`id_razdel`)))
client_cs_name=utf8
connection_cl_name=utf8_general_ci
view_body_utf8=select `mathematical_analysis`.`konspetti_primerov`.`konspekt_primera` AS `konspekt_primera`,`mathematical_analysis`.`temi`.`name_temi` AS `name_temi`,`mathematical_analysis`.`razdel`.`name_razdel` AS `name_razdel` from ((`mathematical_analysis`.`konspetti_primerov` join `mathematical_analysis`.`temi` on((`mathematical_analysis`.`konspetti_primerov`.`id_temi` = `mathematical_analysis`.`temi`.`id_temi`))) join `mathematical_analysis`.`razdel` on((`mathematical_analysis`.`temi`.`id_razdel` = `mathematical_analysis`.`razdel`.`id_razdel`)))
