select p.product_name, c.cat_name
from PROD_CATS pc
left join products p on (pc.product_id = p.product_id)
left join categories c on (pc.cat_id = c.cat_id)