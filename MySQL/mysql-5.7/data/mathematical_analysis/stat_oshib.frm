TYPE=VIEW
query=select count(`mathematical_analysis`.`oshibki`.`id_popitka`) AS `id_popitka`,`mathematical_analysis`.`tests`.`name_test` AS `name_test`,concat(`mathematical_analysis`.`users`.`familia`,\' \',`mathematical_analysis`.`users`.`name`,\' \',`mathematical_analysis`.`users`.`otchestvo`) AS `FIO`,`mathematical_analysis`.`popitki`.`id_users` AS `id_users` from (((`mathematical_analysis`.`oshibki` join `mathematical_analysis`.`tests`) join `mathematical_analysis`.`popitki` on(((`mathematical_analysis`.`oshibki`.`id_popitka` = `mathematical_analysis`.`popitki`.`id_popitka`) and (`mathematical_analysis`.`popitki`.`id_tests` = `mathematical_analysis`.`tests`.`id_test`)))) join `mathematical_analysis`.`users` on((`mathematical_analysis`.`popitki`.`id_users` = `mathematical_analysis`.`users`.`id_users`))) group by `mathematical_analysis`.`tests`.`name_test`,`mathematical_analysis`.`users`.`otchestvo`,`mathematical_analysis`.`users`.`name`,`mathematical_analysis`.`users`.`familia`,`mathematical_analysis`.`popitki`.`id_users`
md5=10c6077a00f2670932ad471552d538b0
updatable=0
algorithm=0
definer_user=root
definer_host=localhost
suid=2
with_check_option=0
timestamp=2024-03-27 11:15:45
create-version=1
source=SELECT
client_cs_name=utf8
connection_cl_name=utf8_general_ci
view_body_utf8=select count(`mathematical_analysis`.`oshibki`.`id_popitka`) AS `id_popitka`,`mathematical_analysis`.`tests`.`name_test` AS `name_test`,concat(`mathematical_analysis`.`users`.`familia`,\' \',`mathematical_analysis`.`users`.`name`,\' \',`mathematical_analysis`.`users`.`otchestvo`) AS `FIO`,`mathematical_analysis`.`popitki`.`id_users` AS `id_users` from (((`mathematical_analysis`.`oshibki` join `mathematical_analysis`.`tests`) join `mathematical_analysis`.`popitki` on(((`mathematical_analysis`.`oshibki`.`id_popitka` = `mathematical_analysis`.`popitki`.`id_popitka`) and (`mathematical_analysis`.`popitki`.`id_tests` = `mathematical_analysis`.`tests`.`id_test`)))) join `mathematical_analysis`.`users` on((`mathematical_analysis`.`popitki`.`id_users` = `mathematical_analysis`.`users`.`id_users`))) group by `mathematical_analysis`.`tests`.`name_test`,`mathematical_analysis`.`users`.`otchestvo`,`mathematical_analysis`.`users`.`name`,`mathematical_analysis`.`users`.`familia`,`mathematical_analysis`.`popitki`.`id_users`