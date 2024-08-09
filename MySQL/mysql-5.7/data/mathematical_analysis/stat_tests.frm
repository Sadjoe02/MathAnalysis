TYPE=VIEW
query=select count(`mathematical_analysis`.`popitki`.`id_users`) AS `id_users`,`mathematical_analysis`.`tests`.`name_test` AS `name_test`,`mathematical_analysis`.`tests`.`id_test` AS `id_test` from (`mathematical_analysis`.`tests` left join `mathematical_analysis`.`popitki` on((`mathematical_analysis`.`popitki`.`id_tests` = `mathematical_analysis`.`tests`.`id_test`))) group by `mathematical_analysis`.`tests`.`name_test`,`mathematical_analysis`.`popitki`.`id_tests`,`mathematical_analysis`.`tests`.`id_test`
md5=76bd02d16c3c18be1c1b984bee37a990
updatable=0
algorithm=0
definer_user=root
definer_host=localhost
suid=2
with_check_option=0
timestamp=2024-03-27 11:15:44
create-version=1
source=SELECT\n  COUNT(`popitki`.`id_users`) AS `id_users`,\n  `tests`.`name_test` AS `name_test`,\n  `tests`.`id_test` AS `id_test`\nFROM (`tests`\n  LEFT JOIN `popitki`\n    ON ((`popitki`.`id_tests` = `tests`.`id_test`)))\nGROUP BY `tests`.`name_test`,\n         `popitki`.`id_tests`,\n         `tests`.`id_test`
client_cs_name=utf8
connection_cl_name=utf8_general_ci
view_body_utf8=select count(`mathematical_analysis`.`popitki`.`id_users`) AS `id_users`,`mathematical_analysis`.`tests`.`name_test` AS `name_test`,`mathematical_analysis`.`tests`.`id_test` AS `id_test` from (`mathematical_analysis`.`tests` left join `mathematical_analysis`.`popitki` on((`mathematical_analysis`.`popitki`.`id_tests` = `mathematical_analysis`.`tests`.`id_test`))) group by `mathematical_analysis`.`tests`.`name_test`,`mathematical_analysis`.`popitki`.`id_tests`,`mathematical_analysis`.`tests`.`id_test`
