TYPE=VIEW
query=select `mathematical_analysis`.`tests`.`name_test` AS `name_test`,`mathematical_analysis`.`tests`.`min_colvo_ball` AS `min_colvo_ball`,`mathematical_analysis`.`users`.`familia` AS `familia`,`mathematical_analysis`.`users`.`name` AS `name`,`mathematical_analysis`.`users`.`otchestvo` AS `otchestvo`,`mathematical_analysis`.`popitki`.`id_users` AS `id_users`,`mathematical_analysis`.`popitki`.`Itog_kolvo_ballov` AS `Itog_kolvo_ballov`,`mathematical_analysis`.`popitki`.`Nomer_popitki` AS `Nomer_popitki`,`mathematical_analysis`.`popitki`.`data_nachala` AS `data_nachala`,`mathematical_analysis`.`popitki`.`data_konca` AS `data_konca` from ((`mathematical_analysis`.`popitki` join `mathematical_analysis`.`users` on((`mathematical_analysis`.`popitki`.`id_users` = `mathematical_analysis`.`users`.`id_users`))) join `mathematical_analysis`.`tests` on((`mathematical_analysis`.`popitki`.`id_tests` = `mathematical_analysis`.`tests`.`id_test`))) where (`mathematical_analysis`.`popitki`.`Itog_kolvo_ballov` >= `mathematical_analysis`.`tests`.`min_colvo_ball`)
md5=87a077e3694dbc074b31450da63b1652
updatable=1
algorithm=0
definer_user=root
definer_host=localhost
suid=2
with_check_option=0
timestamp=2024-03-27 11:15:44
create-version=1
source=SELECT
client_cs_name=utf8
connection_cl_name=utf8_general_ci
view_body_utf8=select `mathematical_analysis`.`tests`.`name_test` AS `name_test`,`mathematical_analysis`.`tests`.`min_colvo_ball` AS `min_colvo_ball`,`mathematical_analysis`.`users`.`familia` AS `familia`,`mathematical_analysis`.`users`.`name` AS `name`,`mathematical_analysis`.`users`.`otchestvo` AS `otchestvo`,`mathematical_analysis`.`popitki`.`id_users` AS `id_users`,`mathematical_analysis`.`popitki`.`Itog_kolvo_ballov` AS `Itog_kolvo_ballov`,`mathematical_analysis`.`popitki`.`Nomer_popitki` AS `Nomer_popitki`,`mathematical_analysis`.`popitki`.`data_nachala` AS `data_nachala`,`mathematical_analysis`.`popitki`.`data_konca` AS `data_konca` from ((`mathematical_analysis`.`popitki` join `mathematical_analysis`.`users` on((`mathematical_analysis`.`popitki`.`id_users` = `mathematical_analysis`.`users`.`id_users`))) join `mathematical_analysis`.`tests` on((`mathematical_analysis`.`popitki`.`id_tests` = `mathematical_analysis`.`tests`.`id_test`))) where (`mathematical_analysis`.`popitki`.`Itog_kolvo_ballov` >= `mathematical_analysis`.`tests`.`min_colvo_ball`)