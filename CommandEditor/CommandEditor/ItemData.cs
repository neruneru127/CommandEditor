﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandEditor
{
    class ItemData
    {
        public struct ItemType
        {
            public string name;
            public string description;
        }

        public static readonly ItemType[] ItemTypeList =
        {
            new ItemType{name = "iron_sword",                description = ""},
            new ItemType{name = "iron_shovel",               description = ""},
            new ItemType{name = "iron_pickaxe",              description = ""},
            new ItemType{name = "iron_axe",                  description = ""},
            new ItemType{name = "iron_hoe",                  description = ""},
            new ItemType{name = "wooden_sword",              description = ""},
            new ItemType{name = "wooden_shovel",             description = ""},
            new ItemType{name = "wooden_pickaxe",            description = ""},
            new ItemType{name = "wooden_axe",                description = ""},
            new ItemType{name = "wooden_hoe",                description = ""},
            new ItemType{name = "stone_sword",               description = ""},
            new ItemType{name = "stone_shovel",              description = ""},
            new ItemType{name = "stone_pickaxe",             description = ""},
            new ItemType{name = "stone_axe",                 description = ""},
            new ItemType{name = "stone_hoe",                 description = ""},
            new ItemType{name = "diamond_sword",             description = ""},
            new ItemType{name = "diamond_shovel",            description = ""},
            new ItemType{name = "diamond_pickaxe",           description = ""},
            new ItemType{name = "diamond_axe",               description = ""},
            new ItemType{name = "diamond_hoe",               description = ""},
            new ItemType{name = "golden_sword",              description = ""},
            new ItemType{name = "golden_shovel",             description = ""},
            new ItemType{name = "golden_pickaxe",            description = ""},
            new ItemType{name = "golden_axe",                description = ""},
            new ItemType{name = "golden_hoe",                description = ""},
            new ItemType{name = "leather_helmet",            description = ""},
            new ItemType{name = "leather_chestplate",        description = ""},
            new ItemType{name = "leather_leggings",          description = ""},
            new ItemType{name = "leather_boots",             description = ""},
            new ItemType{name = "chainmail_helmet",          description = ""},
            new ItemType{name = "chainmail_chestplate",      description = ""},
            new ItemType{name = "chainmail_leggings",        description = ""},
            new ItemType{name = "chainmail_boots",           description = ""},
            new ItemType{name = "iron_helmet",               description = ""},
            new ItemType{name = "iron_chestplate",           description = ""},
            new ItemType{name = "iron_leggings",             description = ""},
            new ItemType{name = "iron_boots",                description = ""},
            new ItemType{name = "diamond_helmet",            description = ""},
            new ItemType{name = "diamond_chestplate",        description = ""},
            new ItemType{name = "diamond_leggings",          description = ""},
            new ItemType{name = "diamond_boots",             description = ""},
            new ItemType{name = "golden_helmet",             description = ""},
            new ItemType{name = "golden_chestplate",         description = ""},
            new ItemType{name = "golden_leggings",           description = ""},
            new ItemType{name = "golden_boots",              description = ""},
            new ItemType{name = "turtle_helmet",             description = ""},
            new ItemType{name = "scute",                     description = ""},
            new ItemType{name = "flint_and_steel",           description = ""},
            new ItemType{name = "bow",                       description = ""},
            new ItemType{name = "arrow",                     description = ""},
            new ItemType{name = "apple",                     description = ""},
            new ItemType{name = "coal",                      description = ""},
            new ItemType{name = "charcoal",                  description = ""},
            new ItemType{name = "diamond",                   description = ""},
            new ItemType{name = "iron_ingot",                description = ""},
            new ItemType{name = "gold_ingot",                description = ""},
            new ItemType{name = "stick",                     description = ""},
            new ItemType{name = "bowl",                      description = ""},
            new ItemType{name = "mushroom_stew",             description = ""},
            new ItemType{name = "string",                    description = ""},
            new ItemType{name = "feather",                   description = ""},
            new ItemType{name = "gunpowder",                 description = ""},
            new ItemType{name = "wheat_seeds",               description = ""},
            new ItemType{name = "wheat",                     description = ""},
            new ItemType{name = "bread",                     description = ""},
            new ItemType{name = "flint",                     description = ""},
            new ItemType{name = "porkchop",                  description = ""},
            new ItemType{name = "cooked_porkchop",           description = ""},
            new ItemType{name = "painting",                  description = ""},
            new ItemType{name = "golden_apple",              description = ""},
            new ItemType{name = "enchanted_golden_apple",    description = ""},
            new ItemType{name = "bucket",                    description = ""},
            new ItemType{name = "water_bucket",              description = ""},
            new ItemType{name = "lava_bucket",               description = ""},
            new ItemType{name = "milk_bucket",               description = ""},
            new ItemType{name = "minecart",                  description = ""},
            new ItemType{name = "saddle",                    description = ""},
            new ItemType{name = "redstone",                  description = ""},
            new ItemType{name = "snowball",                  description = ""},
            new ItemType{name = "oak_boat",                  description = ""},
            new ItemType{name = "spruce_boat",               description = ""},
            new ItemType{name = "birch_boat",                description = ""},
            new ItemType{name = "jungle_boat",               description = ""},
            new ItemType{name = "acacia_boat",               description = ""},
            new ItemType{name = "dark_oak_boat",             description = ""},
            new ItemType{name = "leather",                   description = ""},
            new ItemType{name = "pufferfish_bucket",         description = ""},
            new ItemType{name = "salmon_bucket",             description = ""},
            new ItemType{name = "cod_bucket",                description = ""},
            new ItemType{name = "tropical_fish_bucket",      description = ""},
            new ItemType{name = "brick",                     description = ""},
            new ItemType{name = "clay_ball",                 description = ""},
            new ItemType{name = "sugar_cane",                description = ""},
            new ItemType{name = "kelp",                      description = ""},
            new ItemType{name = "paper",                     description = ""},
            new ItemType{name = "book",                      description = ""},
            new ItemType{name = "slime_ball",                description = ""},
            new ItemType{name = "chest_minecart",            description = ""},
            new ItemType{name = "furnace_minecart",          description = ""},
            new ItemType{name = "tnt_minecart",              description = ""},
            new ItemType{name = "hopper_minecart",           description = ""},
            new ItemType{name = "command_block_minecart",    description = ""},
            new ItemType{name = "egg",                       description = ""},
            new ItemType{name = "compass",                   description = ""},
            new ItemType{name = "fishing_rod",               description = ""},
            new ItemType{name = "clock",                     description = ""},
            new ItemType{name = "glowstone_dust",            description = ""},
            new ItemType{name = "cod",                       description = ""},
            new ItemType{name = "salmon",                    description = ""},
            new ItemType{name = "tropical_fish",             description = ""},
            new ItemType{name = "pufferfish",                description = ""},
            new ItemType{name = "cooked_cod",                description = ""},
            new ItemType{name = "cooked_salmon",             description = ""},
            new ItemType{name = "ink_sac",                   description = ""},
            new ItemType{name = "red_dye‌",                   description = ""},
            new ItemType{name = "green_dye‌",                 description = ""},
            new ItemType{name = "cocoa_beans",               description = ""},
            new ItemType{name = "lapis_lazuli",              description = ""},
            new ItemType{name = "purple_dye",                description = ""},
            new ItemType{name = "cyan_dye",                  description = ""},
            new ItemType{name = "light_gray_dye",            description = ""},
            new ItemType{name = "gray_dye",                  description = ""},
            new ItemType{name = "pink_dye",                  description = ""},
            new ItemType{name = "lime_dye",                  description = ""},
            new ItemType{name = "yellow_dye‌",                description = ""},
            new ItemType{name = "light_blue_dye",            description = ""},
            new ItemType{name = "magenta_dye",               description = ""},
            new ItemType{name = "orange_dye",                description = ""},
            new ItemType{name = "bone_meal",                 description = ""},
            new ItemType{name = "blue_dye‌",                  description = ""},
            new ItemType{name = "brown_dye‌",                 description = ""},
            new ItemType{name = "black_dye‌",                 description = ""},
            new ItemType{name = "white_dye‌",                 description = ""},
            new ItemType{name = "bone",                      description = ""},
            new ItemType{name = "sugar",                     description = ""},
            new ItemType{name = "cookie",                    description = ""},
            new ItemType{name = "shears",                    description = ""},
            new ItemType{name = "melon_slice",               description = ""},
            new ItemType{name = "dried_kelp",                description = ""},
            new ItemType{name = "pumpkin_seeds",             description = ""},
            new ItemType{name = "melon_seeds",               description = ""},
            new ItemType{name = "beef",                      description = ""},
            new ItemType{name = "cooked_beef",               description = ""},
            new ItemType{name = "chicken",                   description = ""},
            new ItemType{name = "cooked_chicken",            description = ""},
            new ItemType{name = "rotten_flesh",              description = ""},
            new ItemType{name = "ender_pearl",               description = ""},
            new ItemType{name = "blaze_rod",                 description = ""},
            new ItemType{name = "ghast_tear",                description = ""},
            new ItemType{name = "gold_nugget",               description = ""},
            new ItemType{name = "nether_wart",               description = ""},
            new ItemType{name = "glass_bottle",              description = ""},
            new ItemType{name = "potion",                    description = ""},
            new ItemType{name = "splash_potion",             description = ""},
            new ItemType{name = "lingering_potion",          description = ""},
            new ItemType{name = "tipped_arrow",              description = ""},
            new ItemType{name = "spectral_arrow",            description = ""},
            new ItemType{name = "spider_eye",                description = ""},
            new ItemType{name = "fermented_spider_eye",      description = ""},
            new ItemType{name = "blaze_powder",              description = ""},
            new ItemType{name = "magma_cream",               description = ""},
            new ItemType{name = "ender_eye",                 description = ""},
            new ItemType{name = "glistering_melon_slice",    description = ""},
            new ItemType{name = "debug_stick",               description = ""},
            new ItemType{name = "bat_spawn_egg",             description = ""},
            new ItemType{name = "blaze_spawn_egg",           description = ""},
            new ItemType{name = "cat_spawn_egg‌",             description = ""},
            new ItemType{name = "cave_spider_spawn_egg",     description = ""},
            new ItemType{name = "chicken_spawn_egg",         description = ""},
            new ItemType{name = "cod_spawn_egg",             description = ""},
            new ItemType{name = "cow_spawn_egg",             description = ""},
            new ItemType{name = "creeper_spawn_egg",         description = ""},
            new ItemType{name = "dolphin_spawn_egg",         description = ""},
            new ItemType{name = "donkey_spawn_egg",          description = ""},
            new ItemType{name = "drowned_spawn_egg",         description = ""},
            new ItemType{name = "elder_guardian_spawn_egg",  description = ""},
            new ItemType{name = "enderman_spawn_egg",        description = ""},
            new ItemType{name = "endermite_spawn_egg",       description = ""},
            new ItemType{name = "evoker_spawn_egg",          description = ""},
            new ItemType{name = "ghast_spawn_egg",           description = ""},
            new ItemType{name = "guardian_spawn_egg",        description = ""},
            new ItemType{name = "horse_spawn_egg",           description = ""},
            new ItemType{name = "husk_spawn_egg",            description = ""},
            new ItemType{name = "illager_beast_spawn_egg‌",   description = ""},
            new ItemType{name = "llama_spawn_egg",           description = ""},
            new ItemType{name = "magma_cube_spawn_egg",      description = ""},
            new ItemType{name = "mooshroom_spawn_egg",       description = ""},
            new ItemType{name = "mule_spawn_egg",            description = ""},
            new ItemType{name = "ocelot_spawn_egg",          description = ""},
            new ItemType{name = "panda_spawn_egg‌",           description = ""},
            new ItemType{name = "parrot_spawn_egg",          description = ""},
            new ItemType{name = "phantom _spawn_egg",        description = ""},
            new ItemType{name = "pig_spawn_egg",             description = ""},
            new ItemType{name = "pillager_spawn_egg‌",        description = ""},
            new ItemType{name = "polar_bear_spawn_egg",      description = ""},
            new ItemType{name = "pufferfish_spawn_egg",      description = ""},
            new ItemType{name = "rabbit_spawn_egg",          description = ""},
            new ItemType{name = "salmon_spawn_egg",          description = ""},
            new ItemType{name = "sheep_spawn_egg",           description = ""},
            new ItemType{name = "shulker_spawn_egg",         description = ""},
            new ItemType{name = "silverfish_spawn_egg",      description = ""},
            new ItemType{name = "skeleton_spawn_egg",        description = ""},
            new ItemType{name = "skeleton_horse_spawn_egg",  description = ""},
            new ItemType{name = "slime_spawn_egg",           description = ""},
            new ItemType{name = "spider_spawn_egg",          description = ""},
            new ItemType{name = "squid_spawn_egg",           description = ""},
            new ItemType{name = "stray_spawn_egg",           description = ""},
            new ItemType{name = "tropical_fish_spawn_egg",   description = ""},
            new ItemType{name = "turtle_spawn_egg",          description = ""},
            new ItemType{name = "vex_spawn_egg",             description = ""},
            new ItemType{name = "villager_spawn_egg",        description = ""},
            new ItemType{name = "vindicator_spawn_egg",      description = ""},
            new ItemType{name = "witch_spawn_egg",           description = ""},
            new ItemType{name = "wither_skeleton_spawn_egg", description = ""},
            new ItemType{name = "wolf_spawn_egg",            description = ""},
            new ItemType{name = "zombie_spawn_egg",          description = ""},
            new ItemType{name = "zombie_horse_spawn_egg",    description = ""},
            new ItemType{name = "zombie_pigman_spawn_egg",   description = ""},
            new ItemType{name = "zombie_villager_spawn_egg", description = ""},
            new ItemType{name = "experience_bottle",         description = ""},
            new ItemType{name = "fire_charge",               description = ""},
            new ItemType{name = "writable_book",             description = ""},
            new ItemType{name = "written_book",              description = ""},
            new ItemType{name = "emerald",                   description = ""},
            new ItemType{name = "item_frame",                description = ""},
            new ItemType{name = "carrot",                    description = ""},
            new ItemType{name = "potato",                    description = ""},
            new ItemType{name = "baked_potato",              description = ""},
            new ItemType{name = "poisonous_potato",          description = ""},
            new ItemType{name = "map",                       description = ""},
            new ItemType{name = "filled_map",                description = ""},
            new ItemType{name = "golden_carrot",             description = ""},
            new ItemType{name = "carrot_on_a_stick",         description = ""},
            new ItemType{name = "nether_star",               description = ""},
            new ItemType{name = "pumpkin_pie",               description = ""},
            new ItemType{name = "firework_rocket",           description = ""},
            new ItemType{name = "firework_star",             description = ""},
            new ItemType{name = "enchanted_book",            description = ""},
            new ItemType{name = "nether_brick",              description = ""},
            new ItemType{name = "quartz",                    description = ""},
            new ItemType{name = "prismarine_shard",          description = ""},
            new ItemType{name = "prismarine_crystals",       description = ""},
            new ItemType{name = "rabbit",                    description = ""},
            new ItemType{name = "cooked_rabbit",             description = ""},
            new ItemType{name = "rabbit_stew",               description = ""},
            new ItemType{name = "rabbit_foot",               description = ""},
            new ItemType{name = "rabbit_hide",               description = ""},
            new ItemType{name = "armor_stand",               description = ""},
            new ItemType{name = "iron_horse_armor",          description = ""},
            new ItemType{name = "golden_horse_armor",        description = ""},
            new ItemType{name = "diamond_horse_armor",       description = ""},
            new ItemType{name = "lead",                      description = ""},
            new ItemType{name = "name_tag",                  description = ""},
            new ItemType{name = "mutton",                    description = ""},
            new ItemType{name = "cooked_mutton",             description = ""},
            new ItemType{name = "end_crystal",               description = ""},
            new ItemType{name = "chorus_fruit",              description = ""},
            new ItemType{name = "popped_chorus_fruit",       description = ""},
            new ItemType{name = "beetroot",                  description = ""},
            new ItemType{name = "beetroot_seeds",            description = ""},
            new ItemType{name = "beetroot_soup",             description = ""},
            new ItemType{name = "dragon_breath",             description = ""},
            new ItemType{name = "shield",                    description = ""},
            new ItemType{name = "elytra",                    description = ""},
            new ItemType{name = "totem_of_undying",          description = ""},
            new ItemType{name = "shulker_shell",             description = ""},
            new ItemType{name = "iron_nugget",               description = ""},
            new ItemType{name = "trident",                   description = ""},
            new ItemType{name = "phantom_membrane",          description = ""},
            new ItemType{name = "nautilus_shell",            description = ""},
            new ItemType{name = "heart_of_the_sea",          description = ""},
            new ItemType{name = "music_disc_13",             description = ""},
            new ItemType{name = "music_disc_cat",            description = ""},
            new ItemType{name = "music_disc_blocks",         description = ""},
            new ItemType{name = "music_disc_chirp",          description = ""},
            new ItemType{name = "music_disc_far",            description = ""},
            new ItemType{name = "music_disc_mall",           description = ""},
            new ItemType{name = "music_disc_mellohi",        description = ""},
            new ItemType{name = "music_disc_stal",           description = ""},
            new ItemType{name = "music_disc_strad",          description = ""},
            new ItemType{name = "music_disc_ward",           description = ""},
            new ItemType{name = "music_disc_11",             description = ""},
            new ItemType{name = "music_disc_wait",           description = ""},
            new ItemType{name = "crossbow‌",                  description = ""},
            new ItemType{name = "flower_banner_pattern‌",     description = ""},
            new ItemType{name = "creeper_banner_pattern‌",    description = ""},
            new ItemType{name = "skull_banner_pattern‌",      description = ""},
            new ItemType{name = "mojang_banner_pattern‌",     description = ""},
            new ItemType{name = "sweet_berries‌",             description = ""},
            new ItemType{name = "suspicious_stew‌",           description = ""},
        };

        private int itemTypeIndex = 0;

        public void SetItemTypeIndex(int index)
        {
            itemTypeIndex = index;
        }

        public int GetItemTypeIndex()
        {
            return itemTypeIndex;
        }

        public override string ToString()
        {
            return ItemTypeList[itemTypeIndex].name;
        }
    }
}
